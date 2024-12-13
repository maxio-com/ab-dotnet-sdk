using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Authentication;

namespace AdvancedBillingTests
{
    internal static class InvalidClient
    {
        public static AdvancedBillingClient GetInvalidClient()
        {
            var builder = new AdvancedBillingClient.Builder();
            builder.Site("dotnet-sdk");
            builder.BasicAuthCredentials(new BasicAuthModel.Builder("abc", "123").Build());

            return builder.Build();
        }
    }
}
