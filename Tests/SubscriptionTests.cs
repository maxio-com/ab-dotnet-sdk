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

            await ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfile, productResponse);
        }

        [Fact]
        public async Task
            CreateSubscription_WrongCouponCodeProvidedToSubscription_ShouldHaveUnprocessableStatusWithMeaningfulError()
        {
            var productFamilyId = await CreateOrGetProductFamily();

            var product = await CreateProduct(productFamilyId);

            var randomString = GenerateRandomString(8);

            var meteredComponent = new MeteredComponent($"ApiCalls{randomString}", $"api call {randomString}",
                PricingScheme.PerUnit, unitPrice: MeteredComponentUnitPrice.FromString("1"));

            var componentResponse = await _client.ComponentsController.CreateComponentAsync((int)productFamilyId,
                ComponentKindPath.MeteredComponents,
                CreateComponentBody.FromCreateMeteredComponent(new CreateMeteredComponent(meteredComponent)));

            componentResponse.Component.Id.Should().NotBeNull();

            var couponCode = $"100{randomString}OFF";

            var createOrUpdatePercentageCoupon = new CreateOrUpdatePercentageCoupon("100% off first month of usage",
                couponCode, CreateOrUpdatePercentageCouponPercentage.FromPrecision(100), "100% off one-time", "false",
                "false", "2024-08-29T12:00:00-04:00", productFamilyId.ToString(), "false",
                excludeMidPeriodAllocations: true, applyOnCancelAtEndOfPeriod: true);

            var restrictedProductDictionary = new Dictionary<string, bool> { { product.Product.Id.ToString()!, true } };
            var restrictedComponentsDictionary = new Dictionary<string, bool>
            {
                { componentResponse.Component.Id.ToString()!, true }
            };

            var couponResponse = await _client.CouponsController.CreateCouponAsync((int)productFamilyId,
                new CreateOrUpdateCoupon(
                    CreateOrUpdateCouponCoupon.FromCreateOrUpdatePercentageCoupon(createOrUpdatePercentageCoupon),
                    restrictedProductDictionary, restrictedComponentsDictionary));
            couponResponse.Coupon.Id.Should().NotBeNull();

            var customer = await CreateCustomer();

            var paymentProfile = await CreatePaymentProfile(customer.Customer.Id);

            var initialBillingDate = DateTime.Now.AddDays(20);

            var wrongCouponCode = $"WrongCode{randomString}";

            var createdSubscription = new CreateSubscription
            {
                CustomerId = customer.Customer.Id,
                ProductId = product.Product.Id,
                PaymentCollectionMethod = PaymentCollectionMethod.Automatic,
                PaymentProfileId = paymentProfile.PaymentProfile.Id,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false,
                Components = new List<CreateSubscriptionComponent>()
                {
                    new CreateSubscriptionComponent(
                        CreateSubscriptionComponentComponentId.FromNumber((int)componentResponse.Component.Id),
                        quantity: 10)
                },
                CouponCode = wrongCouponCode,
                InitialBillingAt = initialBillingDate.ToString("yyyy-MM-dd")
            };

            await _client.Invoking(c => c.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(createdSubscription))).Should()
                .ThrowAsync<ErrorListResponseException>()
                .Where(e => e.ResponseCode == 422 && e.Errors.Any(a => a.Contains("Coupon code could not be found")));

            await ExecuteCleanupForPaymentProfileProductCustomer(customer, paymentProfile, product);

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
                PaymentCollectionMethod = PaymentCollectionMethod.Automatic,
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
                InitialBillingAt = _fixture.Create<DateTime>().ToString("yyyy-MM-dd")
            };

            await invalidClient.Invoking(c => c.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(createdSubscription))).Should()
                .ThrowAsync<ApiException>()
                .Where(e => e.ResponseCode == 401);
        }

        [Fact]
        public async Task CreateSubscription_RestrictedCouponMeteredComponentData_ShouldHaveAwaitingSignupStatus()
        {
            var productFamilyId = await CreateOrGetProductFamily();

            var product = await CreateProduct(productFamilyId);

            var randomString = GenerateRandomString(4);

            var quantityComponent = new QuantityBasedComponent($"widget{randomString}", $"widget {randomString}",
                PricingScheme.PerUnit, unitPrice: QuantityBasedComponentUnitPrice.FromPrecision(1));

            var restrictedComponentResponse = await _client.ComponentsController.CreateComponentAsync(
                (int)productFamilyId,
                ComponentKindPath.QuantityBasedComponents,
                CreateComponentBody.FromCreateQuantityBasedComponent(
                    new CreateQuantityBasedComponent(quantityComponent)));

            restrictedComponentResponse.Component.Id.Should().NotBeNull();

            var meteredComponent = new MeteredComponent($"ApiCalls{randomString}", $"api call {randomString}",
                PricingScheme.PerUnit, unitPrice: MeteredComponentUnitPrice.FromString("1"));

            var componentResponse = await _client.ComponentsController.CreateComponentAsync((int)productFamilyId,
                ComponentKindPath.MeteredComponents,
                CreateComponentBody.FromCreateMeteredComponent(new CreateMeteredComponent(meteredComponent)));

            componentResponse.Component.Id.Should().NotBeNull();

            var couponCode = $"100{randomString}OFF";

            var createOrUpdatePercentageCoupon = new CreateOrUpdatePercentageCoupon("100% off first month of usage",
                couponCode, CreateOrUpdatePercentageCouponPercentage.FromPrecision(100), "100% off one-time", "false",
                "false", "2024-08-29T12:00:00-04:00", productFamilyId.ToString(), "false",
                excludeMidPeriodAllocations: true, applyOnCancelAtEndOfPeriod: true);

            var restrictedProductDictionary = new Dictionary<string, bool> { { product.Product.Id.ToString()!, true } };
            var restrictedComponentsDictionary = new Dictionary<string, bool>
            {
                { restrictedComponentResponse.Component.Id.ToString()!, false },
                { componentResponse.Component.Id.ToString()!, true }
            };

            var couponResponse = await _client.CouponsController.CreateCouponAsync((int)productFamilyId,
                new CreateOrUpdateCoupon(
                    CreateOrUpdateCouponCoupon.FromCreateOrUpdatePercentageCoupon(createOrUpdatePercentageCoupon),
                    restrictedProductDictionary, restrictedComponentsDictionary));
            couponResponse.Coupon.Id.Should().NotBeNull();

            var customer = await CreateCustomer();

            var paymentProfile = await CreatePaymentProfile(customer.Customer.Id);

            var initialBillingDate = DateTime.Now.AddDays(20);

            var createdSubscription = new CreateSubscription
            {
                CustomerId = customer.Customer.Id,
                ProductId = product.Product.Id,
                PaymentCollectionMethod = PaymentCollectionMethod.Automatic,
                PaymentProfileId = paymentProfile.PaymentProfile.Id,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false,
                Components = new List<CreateSubscriptionComponent>()
                {
                    new CreateSubscriptionComponent(
                        CreateSubscriptionComponentComponentId.FromNumber((int)componentResponse.Component.Id),
                        quantity: 10)
                },
                CouponCode = couponCode,
                InitialBillingAt = initialBillingDate.ToString("yyyy-MM-dd")
            };
            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(createdSubscription));

            subscriptionResponse.Subscription.Id.Should().NotBeNull();
            subscriptionResponse.Subscription.State.Should().Be(SubscriptionState.AwaitingSignup);

            await ExecuteBasicSubscriptionCleanup(subscriptionResponse, customer, paymentProfile, product);

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

            await ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfile, productResponse);
        }

        private async Task ExecuteBasicSubscriptionCleanup(SubscriptionResponse subscriptionResponse,
            CustomerResponse customerResponse, CreatePaymentProfileResponse paymentProfile, ProductResponse productResponse)
        {
            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.SubscriptionsController.PurgeSubscriptionAsync((int)subscriptionResponse.Subscription.Id,
                    (int)customerResponse.Customer.Id);
            });

            await ExecuteCleanupForPaymentProfileProductCustomer(customerResponse, paymentProfile, productResponse);
        }

        private async Task ExecuteCleanupForPaymentProfileProductCustomer(CustomerResponse customerResponse,
            CreatePaymentProfileResponse paymentProfile, ProductResponse productResponse)
        {
            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.PaymentProfilesController.DeleteUnusedPaymentProfileAsync(paymentProfile.ToString());
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.CustomersController.DeleteCustomerAsync((int)customerResponse.Customer.Id);
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ProductsController.ArchiveProductAsync((int)productResponse.Product.Id);
            });
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

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
