using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBillingTests.Utils;
using AutoFixture;

namespace AdvancedBillingTests
{
    public class CustomFieldTests
    {
        private readonly AdvancedBillingClient _client = Client.GetClient();
        private readonly Fixture _fixture = new();

        [Fact]
        public async Task CreateMetafields_ResourceTypeSubscription_ResourceIsCreatedValuesAreMappedCorrectly()
        {
            var metadataName = $"{TestUtils.GenerateRandomString(4)}dropdown";

            var dropDownOption1 = $"{TestUtils.GenerateRandomString(5)}doption";
            var dropDownOption2 = $"{TestUtils.GenerateRandomString(5)}doption";

            var optionsList = new List<string> { dropDownOption1, dropDownOption2 };

            var metaData = new CreateMetafield(name: metadataName, scope: new MetafieldScope(publicEdit: IncludeOption.Include, publicShow: IncludeOption.Include), inputType: MetafieldInput.Dropdown, mEnum: optionsList);

            var metadataList = new List<CreateMetafield> { metaData };

            var anotherTest = _client.CustomFieldsController.CreateMetafields(ResourceType.Subscriptions,
                new CreateMetafieldsRequest(CreateMetafieldsRequestMetafields.FromListOfCreateMetafield(metadataList)));

            try
            {
                var metaResponse = await _client.CustomFieldsController.CreateMetafieldsAsync(ResourceType.Subscriptions,
                    new CreateMetafieldsRequest(CreateMetafieldsRequestMetafields.FromCreateMetafield(metaData)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
