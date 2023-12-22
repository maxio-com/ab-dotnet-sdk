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
            var productInfo = new CreateOrUpdateProduct()
            var product = await _client.ProductsController.CreateProductAsync(1, new CreateOrUpdateProductRequest())
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
