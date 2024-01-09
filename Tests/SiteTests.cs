using AdvancedBilling.Standard.Exceptions;
using FluentAssertions;

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
            var invalidClient = InvalidClient.GetInvalidClient();

            await invalidClient.Invoking(i => i.SitesController.ReadSiteAsync()).Should().ThrowAsync<ApiException>().Where(e => e.ResponseCode == 401);
        }
    }
}