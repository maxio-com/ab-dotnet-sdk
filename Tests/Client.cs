using AdvancedBilling.Standard;
using Environment = AdvancedBilling.Standard.Environment;
using AdvancedBilling.Standard.Authentication;

namespace AdvancedBillingTests
{
    internal static class Client
    {
        public static AdvancedBillingClient GetClient()
        {
            var apiKey = System.Environment.GetEnvironmentVariable("TEST_API_KEY");
            var password = System.Environment.GetEnvironmentVariable("TEST_PASSWORD");
            var domain = System.Environment.GetEnvironmentVariable("TEST_DOMAIN");
            var subdomain = System.Environment.GetEnvironmentVariable("TEST_SUBDOMAIN");
            var builder = new AdvancedBillingClient.Builder();
            builder.BasicAuthCredentials(new BasicAuthModel.Builder(apiKey, password).Build());
            builder.Environment(Environment.Production);
            builder.Domain(domain);
            builder.Subdomain(subdomain);

            return builder.Build();
        }
    }
}
