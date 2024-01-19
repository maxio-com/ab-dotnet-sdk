using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Models;
using AutoFixture;
using AdvancedBilling.Standard;
using FluentAssertions;

namespace AdvancedBillingTests.Utils
{
    public static class CreationUtils
    {
        private static readonly Fixture _fixture = new();

        public static async Task<CreatePaymentProfileResponse> CreatePaymentProfile(int? customerId, AdvancedBillingClient client)
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
                await client.PaymentProfilesController.CreatePaymentProfileAsync(
                    new CreatePaymentProfileRequest(paymentProfile));

            paymentProfileResponse.PaymentProfile.Id.Should().NotBeNull();
            return paymentProfileResponse;
        }

        public static async Task<CustomerResponse> CreateCustomer(AdvancedBillingClient client)
        {
            var customerName = _fixture.Create<string>();
            var customerLastName = _fixture.Create<string>();
            var emailStub = "dummy123@gmail.com";
            var customer = new CreateCustomer(customerName, customerLastName, emailStub);

            var customerResponse =
                await client.CustomersController.CreateCustomerAsync(new CreateCustomerRequest(customer));
            customerResponse.Customer.Id.Should().NotBeNull();
            customerResponse.Customer.FirstName.Should().Be(customerName);
            customerResponse.Customer.LastName.Should().Be(customerLastName);
            customerResponse.Customer.Email.Should().Be(emailStub);
            return customerResponse;
        }

        public static async Task<ProductResponse> CreateProduct(int? productFamilyId, AdvancedBillingClient client)
        {
            var productName = _fixture.Create<string>();

            var productInfo = new CreateOrUpdateProduct(productName, _fixture.Create<string>(), _fixture.Create<long>(),
                _fixture.Create<int>(), IntervalUnit.Day);

            var productResponse =
                await client.ProductsController.CreateProductAsync((int)productFamilyId,
                    new CreateOrUpdateProductRequest(productInfo));

            productResponse.Product.Id.Should().NotBeNull();
            productResponse.Product.Name.Should().Be(productName);
            return productResponse;
        }

        public static async Task<int?> CreateOrGetProductFamily(AdvancedBillingClient client)
        {
            var productFamilies =
                await client.ProductFamiliesController.ListProductFamiliesAsync(new ListProductFamiliesInput());

            var productFamilyId = productFamilies.FirstOrDefault()?.ProductFamily.Id;

            if (productFamilyId == null)
            {
                var productFamilyName = _fixture.Create<string>();
                var productFamily = new CreateProductFamily(productFamilyName, _fixture.Create<string>());

                var productFamilyResponse = await
                    client.ProductFamiliesController.CreateProductFamilyAsync(
                        new CreateProductFamilyRequest(productFamily));

                productFamilyResponse.ProductFamily.Id.Should().NotBeNull();
                productFamilyId = (int)productFamilyResponse.ProductFamily.Id!;
            }

            return productFamilyId;
        }
    }
}
