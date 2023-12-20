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
        public async Task CreateSubscription_ShouldSucceed()
        {
            var subscription = _fixture.Create<CreateSubscription>();
            var subscriptionRequest = new CreateSubscriptionRequest(subscription);

            try
            {
                var response = await _client.SubscriptionsController.CreateSubscriptionAsync(subscriptionRequest);

                response.Should().NotBeNull();

                var createdSubscriptionId = response.Subscription.Id;

                createdSubscriptionId.Should().NotBeNull();
                createdSubscriptionId.Should().BeGreaterThan(0);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
