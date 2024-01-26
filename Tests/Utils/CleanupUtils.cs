using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard;

namespace AdvancedBillingTests.Utils
{
    public static class CleanupUtils
    {
        public static async Task ExecuteBasicSubscriptionCleanup(SubscriptionResponse subscriptionResponse,
            CustomerResponse customerResponse, int paymentProfileId, ProductResponse productResponse, AdvancedBillingClient client)
        {
            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await client.SubscriptionsController.PurgeSubscriptionAsync((int)subscriptionResponse.Subscription.Id,
                    (int)customerResponse.Customer.Id);
            });

            await ExecuteCleanupForPaymentProfileProductCustomer(customerResponse, paymentProfileId, productResponse, client);
        }

        public static async Task ExecuteCleanupForPaymentProfileProductCustomer(CustomerResponse customerResponse,
            int paymentProfileId, ProductResponse productResponse, AdvancedBillingClient client)
        {
            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await client.PaymentProfilesController.DeleteUnusedPaymentProfileAsync(paymentProfileId);
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await client.CustomersController.DeleteCustomerAsync((int)customerResponse.Customer.Id);
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await client.ProductsController.ArchiveProductAsync((int)productResponse.Product.Id);
            });
        }
    }
}
