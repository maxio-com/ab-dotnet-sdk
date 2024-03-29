﻿using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBillingTests.Utils;
using AutoFixture;
using FluentAssertions;

namespace AdvancedBillingTests
{
    public class CustomFieldTests
    {
        private readonly AdvancedBillingClient _client = Client.GetClient();
        private readonly Fixture _fixture = new();

        [Theory]
        [InlineData(MetafieldInput.Dropdown)]
        [InlineData(MetafieldInput.Radio)]
        [InlineData(MetafieldInput.Text)]
        public async Task CreateMetafields_GivenResourceTypeForSubscription_ResourceIsCreatedValuesAreMappedCorrectly(
            MetafieldInput inputType)
        {
            var metadataName = $"{TestUtils.GenerateRandomString(4)}{inputType.ToString()}";

            var dropDownOption1 = $"{TestUtils.GenerateRandomString(5)}doption";
            var dropDownOption2 = $"{TestUtils.GenerateRandomString(5)}doption";

            var optionsList = new List<string> { dropDownOption1, dropDownOption2 };

            var metaData = new CreateMetafield(name: metadataName,
                scope: new MetafieldScope(publicEdit: IncludeOption.Include, publicShow: IncludeOption.Include),
                inputType: inputType, mEnum: optionsList);

            var metaResponse = await _client.CustomFieldsController.CreateMetafieldsAsync(ResourceType.Subscriptions,
                new CreateMetafieldsRequest(CreateMetafieldsRequestMetafields.FromCreateMetafield(metaData)));

            metaResponse.FirstOrDefault().Should().NotBeNull();

            var firstMetaResponse = metaResponse.FirstOrDefault();

            firstMetaResponse?.InputType.Should().Be(inputType);

            var listOfDropdownOptions = firstMetaResponse?.MEnum.Match(x => new List<string> { x }, y => y);

            listOfDropdownOptions.Should().Contain(dropDownOption1);
            listOfDropdownOptions.Should().Contain(dropDownOption2);

            await _client.CustomFieldsController.DeleteMetafieldAsync(ResourceType.Subscriptions, metadataName);
        }

        [Fact]
        public async Task
            CreateMetafields_ResourceTypeSubscriptionDefaultMinimalValues_ResourceIsCreatedValuesAreMappedCorrectly()
        {
            var defaultMetadataName = $"{TestUtils.GenerateRandomString(4)}minvalname";

            var dropDownOption1 = $"{TestUtils.GenerateRandomString(5)}doption";
            var dropDownOption2 = $"{TestUtils.GenerateRandomString(5)}doption";

            var optionsList = new List<string> { dropDownOption1, dropDownOption2 };

            var defaultMetadata = new CreateMetafield(name: defaultMetadataName, mEnum: optionsList);

            var defaultMetaResponse = await _client.CustomFieldsController.CreateMetafieldsAsync(
                ResourceType.Subscriptions,
                new CreateMetafieldsRequest(CreateMetafieldsRequestMetafields.FromCreateMetafield(defaultMetadata)));

            defaultMetaResponse.FirstOrDefault().Should().NotBeNull();

            var firstDefaultMetaResponse = defaultMetaResponse.FirstOrDefault();

            firstDefaultMetaResponse?.InputType.Should().Be(MetafieldInput.Text);

            var listOfDropdownOptions = firstDefaultMetaResponse?.MEnum.Match(x => new List<string> { x }, y => y);

            listOfDropdownOptions.Should().Contain(dropDownOption1);
            listOfDropdownOptions.Should().Contain(dropDownOption2);

            await _client.CustomFieldsController.DeleteMetafieldAsync(ResourceType.Subscriptions, defaultMetadataName);
        }

        [Fact]
        public async Task
            CreateMetadata_ResourceTypeSubscriptionReferenceProvided_ResourceIsCreatedValuesAreMappedCorrectly()
        {
            var metadataName = $"{TestUtils.GenerateRandomString(4)}metaname";

            var option1 = $"{TestUtils.GenerateRandomString(5)}option";
            var option2 = $"{TestUtils.GenerateRandomString(5)}option";

            var optionsList = new List<CreateMetadata> { new(metadataName, option1), new(metadataName, option2) };

            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var productResponse = await CreationUtils.CreateProduct(productFamilyId, _client);

            var customerResponse = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customerResponse.Customer.Id, _client);

            var subscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(subscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();

            var metadatas = await _client.CustomFieldsController.CreateMetadataAsync(ResourceType.Subscriptions,
                (int) subscriptionResponse.Subscription.Id,
                new CreateMetadataRequest(optionsList));

            metadatas.Should().Contain(x => x.MValue == option1 && x.Name == metadataName);
            metadatas.Should().Contain(x => x.MValue == option2 && x.Name == metadataName);

            //// TODO: It is not working, to be investigated
            //var listOfMetadata =
            //    await _client.CustomFieldsController.ListMetadataForResourceTypeAsync(
            //        new ListMetadataForResourceTypeInput(ResourceType.Subscriptions));

            //listOfMetadata.Metadata.Should().Contain(x => x.MValue == option1 && x.Name == metadataName);
            //listOfMetadata.Metadata.Should().Contain(x => x.MValue == option2 && x.Name == metadataName);

            await _client.CustomFieldsController.DeleteMetadataAsync(ResourceType.Subscriptions,
                (int) subscriptionResponse.Subscription.Id, metadataName);

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId,
                productResponse, _client);
        }

        [Fact]
        public async Task
            CreateMetadata_ResourceTypeCustomerReferenceProvided_ResourceIsCreatedValuesAreMappedCorrectly()
        {
            var metadataName = $"{TestUtils.GenerateRandomString(4)}metaname";

            var option1 = $"{TestUtils.GenerateRandomString(5)}option";
            var option2 = $"{TestUtils.GenerateRandomString(5)}option";

            var optionsList = new List<CreateMetadata> { new(metadataName, option1), new(metadataName, option2) };

            var customerResponse = await CreationUtils.CreateCustomer(_client);

            var metadatas = await _client.CustomFieldsController.CreateMetadataAsync(ResourceType.Customers,
                (int) customerResponse.Customer.Id,
                new CreateMetadataRequest(optionsList));

            metadatas.Should().Contain(x => x.MValue == option1 && x.Name == metadataName);
            metadatas.Should().Contain(x => x.MValue == option2 && x.Name == metadataName);

            await _client.CustomFieldsController.DeleteMetadataAsync(ResourceType.Customers,
                (int) customerResponse.Customer.Id, metadataName);

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.CustomersController.DeleteCustomerAsync((int)customerResponse.Customer.Id);
            });
        }
    }
}
