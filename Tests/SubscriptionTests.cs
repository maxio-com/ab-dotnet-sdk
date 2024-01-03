using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using AutoFixture;
using FluentAssertions;

namespace AdvancedBillingTests
{
    public class SubscriptionTests
    {
        private readonly AdvancedBillingClient _client = Client.GetClient();
        private readonly Fixture _fixture = new();

        [Fact]
        public async Task CreateSubscription_WithDummyData_ShouldFailWithAnyErrorMessage()
        {
            var subscription = _fixture.Create<CreateSubscription>();
            var subscriptionRequest = new CreateSubscriptionRequest(subscription);

            await _client.Invoking(s => s.SubscriptionsController.CreateSubscriptionAsync(subscriptionRequest)).Should()
                .ThrowAsync<ErrorListResponseException>()
                .Where(e => e.Errors.Count > 0);
        }

        [Fact]
        public async Task CreateSubscription_BasicScenarioData_ShouldSuccess()
        {
            var productFamilyId = await CreateOrGetProductFamily();

            var productResponse = await CreateProduct(productFamilyId);

            var customerResponse = await CreateCustomer();

            var paymentProfile = await CreatePaymentProfile(customerResponse.Customer.Id);

            var subscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = PaymentCollectionMethod.Automatic,
                PaymentProfileId = paymentProfile.PaymentProfile.Id,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(subscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();

            try
            {
                await _client.SubscriptionsController.PurgeSubscriptionAsync((int)subscriptionResponse.Subscription.Id,
                    (int)customerResponse.Customer.Id);

                await _client.PaymentProfilesController.DeleteUnusedPaymentProfileAsync(paymentProfile.ToString());

                await _client.CustomersController.DeleteCustomerAsync((int)customerResponse.Customer.Id);
                await _client.ProductsController.ArchiveProductAsync((int)productResponse.Product.Id);
            }
            catch (ApiException e)
            {
                // Suppress Errors on Cleanup
            }
        }

        [Fact]
        public async Task CreateSubscription_RestrictedCouponMeteredComponentData_ShouldHaveAwaitingSignupStatus()
        {
            var productFamilyId = await CreateOrGetProductFamily();

            var restrictedProduct = await CreateProduct(productFamilyId);

            var randomChar = _fixture.Create<char>();

            var quantityComponent = new QuantityBasedComponent($"widget{randomChar}", $"widget {randomChar}",
                PricingScheme.PerUnit, unitPrice: QuantityBasedComponentUnitPrice.FromPrecision(1));

            var restrictedComponentResponse = await _client.ComponentsController.CreateComponentAsync((int)productFamilyId,
                ComponentKindPath.QuantityBasedComponents,
                CreateComponentBody.FromCreateQuantityBasedComponent(new CreateQuantityBasedComponent(quantityComponent)));

            restrictedComponentResponse.Component.Id.Should().NotBeNull();

            var meteredComponent = new MeteredComponent($"ApiCalls{randomChar}", $"api call {randomChar}",
                PricingScheme.PerUnit, unitPrice: MeteredComponentUnitPrice.FromString("1"));

            var componentResponse = await _client.ComponentsController.CreateComponentAsync((int)productFamilyId,
                ComponentKindPath.MeteredComponents,
                CreateComponentBody.FromCreateMeteredComponent(new CreateMeteredComponent(meteredComponent)));

            componentResponse.Component.Id.Should().NotBeNull();

            var createOrUpdatePercentageCoupon = new CreateOrUpdatePercentageCoupon("100% off first month of usage",
                "100OFF", CreateOrUpdatePercentageCouponPercentage.FromPrecision(100), "100% off one-time", "false",
                "false", "2024-08-29T12:00:00-04:00", productFamilyId.ToString(), "false", excludeMidPeriodAllocations: true, applyOnCancelAtEndOfPeriod: true);

            var restrictedProductDictionary = new Dictionary<string, bool> { { restrictedProduct.Product.Id.ToString()!, false } };
            var restrictedComponentsDictionary = new Dictionary<string, bool> { { restrictedComponentResponse.Component.Id.ToString()!, false }, { componentResponse.Component.Id.ToString()!, true} };

            var test = await _client.CouponsController.CreateCouponAsync((int)productFamilyId,
                new CreateOrUpdateCoupon(
                    CreateOrUpdateCouponCoupon.FromCreateOrUpdatePercentageCoupon(createOrUpdatePercentageCoupon),
                    restrictedProductDictionary, restrictedComponentsDictionary));
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
            var productFamilyId = await CreateOrGetProductFamily();

            var productResponse = await CreateProduct(productFamilyId);

            var customerResponse = await CreateCustomer();

            var paymentProfile = await CreatePaymentProfile(customerResponse.Customer.Id);

            var createdSubscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = PaymentCollectionMethod.Automatic,
                PaymentProfileId = paymentProfile.PaymentProfile.Id,
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
            subscription.Subscription.PaymentCollectionMethod.Should().Be(PaymentCollectionMethod.Automatic);

            try
            {
                await _client.SubscriptionsController.PurgeSubscriptionAsync((int)subscriptionResponse.Subscription.Id,
                    (int)customerResponse.Customer.Id);

                await _client.PaymentProfilesController.DeleteUnusedPaymentProfileAsync(paymentProfile.ToString());

                await _client.CustomersController.DeleteCustomerAsync((int)customerResponse.Customer.Id);
                await _client.ProductsController.ArchiveProductAsync((int)productResponse.Product.Id);
            }
            catch (ApiException e)
            {
                // Suppress Errors on Cleanup
            }
        }

        private async Task<CreatePaymentProfileResponse> CreatePaymentProfile(int? customerId)
        {
            var paymentProfile = new CreatePaymentProfile
            {
                FirstName = _fixture.Create<string>(),
                LastName = _fixture.Create<string>(),
                CardType = CardType.Bogus,
                MaskedCardNumber = "1",
                FullNumber = "1",
                CustomerId = customerId,
                ExpirationMonth = CreatePaymentProfileExpirationMonth.FromNumber(5),
                ExpirationYear = CreatePaymentProfileExpirationYear.FromNumber(2030)
            };


            var paymentProfileResponse =
                await _client.PaymentProfilesController.CreatePaymentProfileAsync(
                    new CreatePaymentProfileRequest(paymentProfile));

            paymentProfileResponse.PaymentProfile.Id.Should().NotBeNull();
            return paymentProfileResponse;
        }

        private async Task<CustomerResponse> CreateCustomer()
        {
            var customerName = _fixture.Create<string>();
            var customerLastName = _fixture.Create<string>();
            var emailStub = "dummy123@gmail.com";
            var customer = new CreateCustomer(customerName, customerLastName, emailStub);

            var customerResponse =
                await _client.CustomersController.CreateCustomerAsync(new CreateCustomerRequest(customer));
            customerResponse.Customer.Id.Should().NotBeNull();
            customerResponse.Customer.FirstName.Should().Be(customerName);
            customerResponse.Customer.LastName.Should().Be(customerLastName);
            customerResponse.Customer.Email.Should().Be(emailStub);
            return customerResponse;
        }

        private async Task<ProductResponse> CreateProduct(int? productFamilyId)
        {
            var productName = _fixture.Create<string>();

            var productInfo = new CreateOrUpdateProduct(productName, _fixture.Create<string>(), _fixture.Create<long>(),
                _fixture.Create<int>(), IntervalUnit.Day);

            var productResponse =
                await _client.ProductsController.CreateProductAsync((int)productFamilyId,
                    new CreateOrUpdateProductRequest(productInfo));

            productResponse.Product.Id.Should().NotBeNull();
            productResponse.Product.Name.Should().Be(productName);
            return productResponse;
        }

        private async Task<int?> CreateOrGetProductFamily()
        {
            var productFamilies =
                await _client.ProductFamiliesController.ListProductFamiliesAsync(new ListProductFamiliesInput());

            var productFamilyId = productFamilies.FirstOrDefault()?.ProductFamily.Id;

            if (productFamilyId == null)
            {
                var productFamilyName = _fixture.Create<string>();
                var productFamily = new CreateProductFamily(productFamilyName, _fixture.Create<string>());

                var productFamilyResponse = await
                    _client.ProductFamiliesController.CreateProductFamilyAsync(
                        new CreateProductFamilyRequest(productFamily));

                productFamilyResponse.ProductFamily.Id.Should().NotBeNull();
                productFamilyId = (int)productFamilyResponse.ProductFamily.Id!;
            }

            return productFamilyId;
        }

    }
}
