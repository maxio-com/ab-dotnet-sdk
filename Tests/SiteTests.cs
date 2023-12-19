using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using FluentAssertions;
using Environment = AdvancedBilling.Standard.Environment;

namespace AdvancedBillingTests
{
    public class SiteTests
    {
        private readonly AdvancedBillingClient.Builder _builder;

        public SiteTests()
        {
            _builder = new AdvancedBillingClient.Builder();
            _builder.BasicAuthCredentials("dkyqT6BldXNYtw3DgLwfRCUOJPDoYoeTO7oUJcadhk", "X");
            _builder.Environment(Environment.Production);
            _builder.Domain("staging-chargify.com");
            _builder.Subdomain("dotnet-sdk");
        }

        [Fact]
        public async Task ValidSiteReading_SuccessfulRequest_ReturnsSiteObject()
        {
            var validClient = _builder.Build();

            var result = await validClient.SitesController.ReadSiteAsync();

            result.Site.Should().NotBeNull();

            result.Site.Name.Should().NotBeNullOrEmpty();

            result.Site.Id.Should().NotBeNull();

            result.Should().NotBeNull();
        }

        [Fact]
        public async Task UnauthorizedSiteReading_InvalidCredentials_Returns401Unauthorized()
        {
            _builder.BasicAuthCredentials("abc", "123");
            var invalidClient = _builder.Build();

            await invalidClient.Invoking(i => i.SitesController.ReadSiteAsync()).Should().ThrowAsync<ApiException>().Where(e => e.ResponseCode == 401);
        }
    }
}