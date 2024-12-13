using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBillingTests.Utils;
using AutoFixture;
using FluentAssertions;

namespace AdvancedBillingTests
{
    public class SubscriptionTests
    {
        private readonly AdvancedBillingClient _client = Client.GetClient();
        private readonly Fixture _fixture = new();

        [Fact]
        public async Task CreateSubscription_BasicScenarioData_ShouldSuccess()
        {
            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var productResponse = await CreationUtils.CreateProduct(productFamilyId, _client);

            var customerResponse = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customerResponse.Customer.Id, _client);

            var subscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(subscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId, productResponse, _client);
        }

        [Fact]
        public async Task
            CreateSubscription_WrongCouponCodeProvidedToSubscription_ShouldHaveUnprocessableStatusWithMeaningfulError()
        {
            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var product = await CreationUtils.CreateProduct(productFamilyId, _client);

            var randomString = TestUtils.GenerateRandomString(8);

            var meteredComponent = new MeteredComponent($"ApiCalls{randomString}", $"api call {randomString}",
                PricingScheme.PerUnit, unitPrice: MeteredComponentUnitPrice.FromString("1"));

            var componentResponse = await _client.ComponentsController
                .CreateMeteredComponentAsync(productFamilyId.ToString(), new CreateMeteredComponent(meteredComponent));

            componentResponse.Component.Id.Should().NotBeNull();

            var couponCode = $"100{randomString}OFF";

            var couponPayload = new CouponPayload("100% off first month of usage",
                couponCode, "100% off one-time", CouponPayloadPercentage.FromPrecision(100), null, false,
                false, DateTime.Now.AddYears(1), productFamilyId.ToString(), false,
                excludeMidPeriodAllocations: true, applyOnCancelAtEndOfPeriod: true);

            var restrictedProductDictionary = new Dictionary<string, bool> { { product.Product.Id.ToString()!, true } };
            var restrictedComponentsDictionary = new Dictionary<string, bool>
            {
                { componentResponse.Component.Id.ToString()!, true }
            };

            var couponResponse = await _client.CouponsController.CreateCouponAsync((int)productFamilyId,
                new CouponRequest(couponPayload, restrictedProductDictionary, restrictedComponentsDictionary));
            couponResponse.Coupon.Id.Should().NotBeNull();

            var customer = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customer.Customer.Id, _client);

            var initialBillingDate = DateTime.Now.AddDays(20);

            var wrongCouponCode = $"WrongCode{randomString}";

            var createdSubscription = new CreateSubscription
            {
                CustomerId = customer.Customer.Id,
                ProductId = product.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false,
                Components = new List<CreateSubscriptionComponent>()
                {
                    new CreateSubscriptionComponent(
                        CreateSubscriptionComponentComponentId.FromNumber((int)componentResponse.Component.Id),
                        quantity: 10)
                },
                CouponCode = wrongCouponCode,
                InitialBillingAt = initialBillingDate
            };

            await _client.Invoking(c => c.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(createdSubscription))).Should()
                .ThrowAsync<ErrorListResponseException>()
                .Where(e => e.ResponseCode == 422 && e.Errors.Any(a => a.Contains("Coupon code could not be found")));

            await CleanupUtils.ExecuteCleanupForPaymentProfileProductCustomer(customer, paymentProfileId, product, _client);

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ComponentsController.ArchiveComponentAsync((int)productFamilyId,
                    componentResponse.Component.Id.ToString());
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.CouponsController.ArchiveCouponAsync((int)productFamilyId, (int)couponResponse.Coupon.Id);
            });
        }

        [Fact]
        public async Task
            CreateSubscription_UnauthorizedAccessCreateSubscription_ShouldHaveReturns401Unauthorized()
        {
            var invalidClient = InvalidClient.GetInvalidClient();

            var createdSubscription = new CreateSubscription
            {
                CustomerId = _fixture.Create<int>(),
                ProductId = _fixture.Create<int>(),
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = _fixture.Create<int>(),
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false,
                Components = new List<CreateSubscriptionComponent>()
                {
                    new CreateSubscriptionComponent(
                        CreateSubscriptionComponentComponentId.FromNumber(_fixture.Create<int>()),
                        quantity: 10)
                },
                CouponCode = _fixture.Create<string>(),
                InitialBillingAt = _fixture.Create<DateTime>()
            };

            await invalidClient.Invoking(c => c.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(createdSubscription))).Should()
                .ThrowAsync<ApiException>()
                .Where(e => e.ResponseCode == 401);
        }

        [Fact]
        public async Task CreateSubscription_RestrictedCouponMeteredComponentData_ShouldHaveAwaitingSignupStatus()
        {
            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var product = await CreationUtils.CreateProduct(productFamilyId, _client);

            var randomString = TestUtils.GenerateRandomString(4);

            var quantityComponent = new QuantityBasedComponent($"widget{randomString}", $"widget {randomString}",
                PricingScheme.PerUnit, unitPrice: QuantityBasedComponentUnitPrice.FromPrecision(1));

            var restrictedComponentResponse = await _client.ComponentsController.CreateQuantityBasedComponentAsync(
                productFamilyId.ToString(),
                new CreateQuantityBasedComponent(quantityComponent));

            restrictedComponentResponse.Component.Id.Should().NotBeNull();

            var meteredComponent = new MeteredComponent($"ApiCalls{randomString}", $"api call {randomString}",
                PricingScheme.PerUnit, unitPrice: MeteredComponentUnitPrice.FromString("1"));

            var componentResponse = await _client.ComponentsController
                .CreateMeteredComponentAsync(productFamilyId.ToString(), new CreateMeteredComponent(meteredComponent));

            componentResponse.Component.Id.Should().NotBeNull();

            var couponCode = $"100{randomString}OFF";

            var couponPayload = new CouponPayload("100% off first month of usage",
                couponCode, "100% off one-time", CouponPayloadPercentage.FromPrecision(100), null, false,
                false, DateTime.Now.AddYears(1), productFamilyId.ToString(), false,
                excludeMidPeriodAllocations: true, applyOnCancelAtEndOfPeriod: true);

            var restrictedProductDictionary = new Dictionary<string, bool> { { product.Product.Id.ToString()!, true } };
            var restrictedComponentsDictionary = new Dictionary<string, bool>
            {
                { restrictedComponentResponse.Component.Id.ToString()!, false },
                { componentResponse.Component.Id.ToString()!, true }
            };

            var couponResponse = await _client.CouponsController.CreateCouponAsync((int)productFamilyId,
                new CouponRequest(couponPayload, restrictedProductDictionary, restrictedComponentsDictionary));
            couponResponse.Coupon.Id.Should().NotBeNull();

            var customer = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customer.Customer.Id, _client);

            var initialBillingDate = DateTime.Now.AddDays(20);

            var createdSubscription = new CreateSubscription
            {
                CustomerId = customer.Customer.Id,
                ProductId = product.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false,
                Components = new List<CreateSubscriptionComponent>()
                {
                    new CreateSubscriptionComponent(
                        CreateSubscriptionComponentComponentId.FromNumber((int)componentResponse.Component.Id),
                        quantity: 10)
                },
                CouponCode = couponCode,
                InitialBillingAt = initialBillingDate
            };
            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(createdSubscription));

            subscriptionResponse.Subscription.Id.Should().NotBeNull();
            subscriptionResponse.Subscription.State.Should().Be(SubscriptionState.AwaitingSignup);

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customer, paymentProfileId, product, _client);

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ComponentsController.ArchiveComponentAsync((int)productFamilyId,
                    componentResponse.Component.Id.ToString());
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ComponentsController.ArchiveComponentAsync((int)productFamilyId,
                    restrictedComponentResponse.Component.Id.ToString());
            });
        }

        [Fact]
        public async Task CreateSubscription_WithMinimalData_ShouldFailWithAnyErrorMessage()
        {
            var subscription = new CreateSubscription();
            var subscriptionRequest = new CreateSubscriptionRequest(subscription);

            await _client.Invoking(s => s.SubscriptionsController.CreateSubscriptionAsync(subscriptionRequest)).Should()
                .ThrowAsync<ErrorListResponseException>()
                .Where(e => e.Errors.Count > 0);
        }

        [Fact]
        public async Task GetSubscription_WithDefaultData_ShouldSuccess()
        {
            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var productResponse = await CreationUtils.CreateProduct(productFamilyId, _client);

            var customerResponse = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customerResponse.Customer.Id, _client);

            var createdSubscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(createdSubscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();
            
            var subscription = await _client.SubscriptionsController.ReadSubscriptionAsync((int)subscriptionResponse.Subscription.Id);

            subscription.Subscription.Id.Should().Be(subscriptionResponse.Subscription.Id);
            subscription.Subscription.Product.Id.Should().Be(productResponse.Product.Id);
            subscription.Subscription.Customer.Id.Should().Be(customerResponse.Customer.Id);
            subscription.Subscription.PaymentCollectionMethod.Should().Be(CollectionMethod.Automatic);

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId, productResponse, _client);
        }
    }
}
