using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Authentication;

namespace AdvancedBillingTests
{
    internal static class Client
    {
        public static AdvancedBillingClient GetClient()
        {
            var apiKey = System.Environment.GetEnvironmentVariable("TEST_API_KEY");
            var password = System.Environment.GetEnvironmentVariable("TEST_PASSWORD");
            var subdomain = System.Environment.GetEnvironmentVariable("TEST_SUBDOMAIN");
            var builder = new AdvancedBillingClient.Builder();
            builder.BasicAuthCredentials(new BasicAuthModel.Builder(apiKey, password).Build());
            builder.Site(subdomain);

            return builder.Build();
        }
    }
}
