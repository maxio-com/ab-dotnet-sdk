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
            System.Environment.SetEnvironmentVariable("TEST_ACCESS_TOKEN", "X");
            System.Environment.SetEnvironmentVariable("TEST_USERNAME", "dkyqT6BldXNYtw3DgLwfRCUOJPDoYoeTO7oUJcadhk");
            var accessToken = System.Environment.GetEnvironmentVariable("TEST_ACCESS_TOKEN");
            var username = System.Environment.GetEnvironmentVariable("TEST_USERNAME");
            _builder = new AdvancedBillingClient.Builder();
            _builder.BasicAuthCredentials(username, accessToken);
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