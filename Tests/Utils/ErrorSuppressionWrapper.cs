using AdvancedBilling.Standard.Exceptions;

namespace AdvancedBillingTests.Utils
{
    public static class ErrorSuppressionWrapper
    {
        public static async Task RunAsync(Func<Task> action)
        {
            try
            {
                await action.Invoke();
            }
            catch (ApiException e)
            {
                // Suppress Errors on Cleanup
            }
        }
    }
}
