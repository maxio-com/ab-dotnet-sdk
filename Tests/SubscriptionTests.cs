using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using AdvancedBilling.Standard.Models;
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
                .ThrowAsync<ApiException>()
                .Where(e => e.Message.Contains("HTTP Response Not OK") && e.Message.Length > "HTTP Response Not OK".Length);

            //var response = await _client.SubscriptionsController.CreateSubscriptionAsync(subscriptionRequest);



            //response.Should().NotBeNull();

            //var createdSubscriptionId = response.Subscription.Id;

            //createdSubscriptionId.Should().NotBeNull();
            //createdSubscriptionId.Should().BeGreaterThan(0);

            // await invalidClient.Invoking(i => i.SitesController.ReadSiteAsync()).Should().ThrowAsync<ApiException>().Where(e => e.ResponseCode == 401);
        }

        [Fact]
        public async Task CreateSubscription_WithHappyPathData_ShouldSuccess()
        {
            var productFamilyName = _fixture.Create<string>();
            var productFamily = new CreateProductFamily(productFamilyName, _fixture.Create<string>());
            var productName = _fixture.Create<string>();
            
            var productFamilyResponse =await 
                _client.ProductFamiliesController.CreateProductFamilyAsync(
                    new CreateProductFamilyRequest(productFamily));

            productFamilyResponse.ProductFamily.Id.Should().NotBeNull();

            var productInfo = new CreateOrUpdateProduct(productName, _fixture.Create<string>(), _fixture.Create<long>(), _fixture.Create<int>(), IntervalUnit.Day);
            
            var productResponse =
                await _client.ProductsController.CreateProductAsync((int)productFamilyResponse.ProductFamily.Id!, new CreateOrUpdateProductRequest(productInfo));

            productResponse.Product.Id.Should().NotBeNull();
            productResponse.Product.Name.Should().Be(productName);

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

            var subscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = PaymentCollectionMethod.Automatic
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(subscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();
        }

        [Fact]
        public async Task CreateSubscription_WithDefaultData_ShouldFailWithAnyErrorMessage()
        {
            //var subscription = _fixture.Create<CreateSubscription>();
            var subscription = new CreateSubscription();
            var subscriptionRequest = new CreateSubscriptionRequest(subscription);

            //await _client.Invoking(s => s.SubscriptionsController.CreateSubscriptionAsync(subscriptionRequest)).Should()
            //    .ThrowAsync<ApiException>()
            //    .Where(e => e.Message.Contains("HTTP Response Not OK") && e.Message.Length > "HTTP Response Not OK".Length);

            try
            {
                var response = await _client.SubscriptionsController.CreateSubscriptionAsync(subscriptionRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //response.Should().NotBeNull();

            //var createdSubscriptionId = response.Subscription.Id;

            //createdSubscriptionId.Should().NotBeNull();
            //createdSubscriptionId.Should().BeGreaterThan(0);

            // await invalidClient.Invoking(i => i.SitesController.ReadSiteAsync()).Should().ThrowAsync<ApiException>().Where(e => e.ResponseCode == 401);
        }

        [Fact]
        public async Task GetSubscription_WithDefaultData_ShouldSuccess()
        {
            try
            {
                var subscription = await _client.SubscriptionsController.ReadSubscriptionAsync(314054);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
