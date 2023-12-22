using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using FluentAssertions;
using Environment = AdvancedBilling.Standard.Environment;

namespace AdvancedBillingTests
{
    public class SiteTests
    {
        [Fact]
        public async Task ValidSiteReading_SuccessfulRequest_ReturnsSiteObject()
        {
            var validClient = Client.GetClient();

            var result = await validClient.SitesController.ReadSiteAsync();

            result.Site.Should().NotBeNull();

            result.Site.Name.Should().NotBeNullOrEmpty();

            result.Site.Id.Should().NotBeNull();

            result.Should().NotBeNull();
        }

        [Fact]
        public async Task UnauthorizedSiteReading_InvalidCredentials_Returns401Unauthorized()
        {
            var builder = new AdvancedBillingClient.Builder();
            builder.Environment(Environment.Production);
            builder.Domain("staging-chargify.com");
            builder.Subdomain("dotnet-sdk");
            builder.BasicAuthCredentials("abc", "123");
            var invalidClient = builder.Build();

            await invalidClient.Invoking(i => i.SitesController.ReadSiteAsync()).Should().ThrowAsync<ApiException>().Where(e => e.ResponseCode == 401);
        }
    }
}