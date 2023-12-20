using AdvancedBilling.Standard;
using Environment = AdvancedBilling.Standard.Environment;

namespace AdvancedBillingTests
{
    internal static class Client
    {
       public static AdvancedBillingClient GetClient()
        {
            System.Environment.SetEnvironmentVariable("TEST_ACCESS_TOKEN", "X");
            System.Environment.SetEnvironmentVariable("TEST_USERNAME", "dkyqT6BldXNYtw3DgLwfRCUOJPDoYoeTO7oUJcadhk");
            var accessToken = System.Environment.GetEnvironmentVariable("TEST_ACCESS_TOKEN");
            var username = System.Environment.GetEnvironmentVariable("TEST_USERNAME");
            var builder = new AdvancedBillingClient.Builder();
            builder.BasicAuthCredentials(username, accessToken);
            builder.Environment(Environment.Production);
            builder.Domain("staging-chargify.com");
            builder.Subdomain("dotnet-sdk");

            return builder.Build();
        }
    }
}
