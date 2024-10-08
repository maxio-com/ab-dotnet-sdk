﻿using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Exceptions;
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Models;
using AdvancedBillingTests.Utils;
using FluentAssertions;

namespace AdvancedBillingTests
{
    public class SubscriptionComponentsTests
    {
        private readonly AdvancedBillingClient _client = Client.GetClient();

        [Fact]
        public async Task AllocateComponents_InvalidQualityOnOffComponent_StatusIs422WithCorrectErrorMessage()
        {
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

            var randomString = TestUtils.GenerateRandomString(6);

            var onOffComponent = new OnOffComponent($"247Support{randomString}",
                unitPrice: OnOffComponentUnitPrice.FromString("100"));

            var onOffComponentResponse = await _client.ComponentsController
                .CreateOnOffComponentAsync(productFamilyId.ToString(), new CreateOnOffComponent(onOffComponent));

            onOffComponentResponse.Component.Id.Should().NotBeNull();

            const int onOffAmount = 50;

            var allocationsList = new List<CreateAllocation>()
            {
                new(onOffAmount, onOffComponentResponse.Component.Id)
            };

            await _client.Invoking(s => s.SubscriptionComponentsController.PreviewAllocationsAsync(
                    (int)subscriptionResponse.Subscription.Id, new PreviewAllocationsRequest(allocationsList))).Should()
                .ThrowAsync<ComponentAllocationErrorException>()
                .Where(e => e.Errors.Any(c => c.Message.Contains("Quantity: must be either 1 (on) or 0 (off).")) &&
                            e.ResponseCode == 422);

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId,
                productResponse, _client);

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ComponentsController.ArchiveComponentAsync((int)productFamilyId,
                    onOffComponentResponse.Component.Id.ToString());
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ComponentsController.ArchiveComponentAsync((int)productFamilyId,
                    onOffComponentResponse.Component.Id.ToString());
            });
        }

        [Fact]
        public async Task ListSubscriptionComponents_UsingInputFilters_ReturnsFilteredData()
        {
            var productFamilyId = await CreationUtils.CreateOrGetProductFamily(_client);

            var productResponse = await CreationUtils.CreateProduct(productFamilyId, _client);

            var customerResponse = await CreationUtils.CreateCustomer(_client);

            var paymentProfileId = await CreationUtils.CreatePaymentProfile(customerResponse.Customer.Id, _client);

            var randomString = TestUtils.GenerateRandomString(6);

            var quantityComponent = new QuantityBasedComponent($"widget{randomString}", $"widget {randomString}",
                PricingScheme.PerUnit, unitPrice: QuantityBasedComponentUnitPrice.FromString("10"));

            var quantityComponentResponse = await _client.ComponentsController.CreateQuantityBasedComponentAsync(
                productFamilyId.ToString(),
                new CreateQuantityBasedComponent(quantityComponent));

            quantityComponentResponse.Component.Id.Should().NotBeNull();

            var subscription = new CreateSubscription
            {
                CustomerId = customerResponse.Customer.Id,
                ProductId = productResponse.Product.Id,
                PaymentCollectionMethod = CollectionMethod.Automatic,
                PaymentProfileId = paymentProfileId,
                DunningCommunicationDelayEnabled = false,
                SkipBillingManifestTaxes = false,
                Components = new List<CreateSubscriptionComponent>() {
                    new CreateSubscriptionComponent {
                        ComponentId = CreateSubscriptionComponentComponentId
                            .FromNumber(quantityComponentResponse.Component.Id.Value),
                        AllocatedQuantity = CreateSubscriptionComponentAllocatedQuantity.FromNumber(2)
                    }
                }
            };

            var subscriptionResponse =
                await _client.SubscriptionsController.CreateSubscriptionAsync(
                    new CreateSubscriptionRequest(subscription));
            subscriptionResponse.Subscription.Id.Should().NotBeNull();

            var filteredComponentsResponse1 =
                await _client.SubscriptionComponentsController.ListSubscriptionComponentsForSiteAsync(
                    new ListSubscriptionComponentsForSiteInput {
                        Filter = new ListSubscriptionComponentsForSiteFilter {
                            Subscription = new SubscriptionFilter {
                                DateField = SubscriptionListDateField.UpdatedAt,
                                StartDate = DateTime.Today.AddYears(-1)
                            }
                        },
                        ProductFamilyIds = new List<int>() { productFamilyId.Value },
                        SubscriptionIds = new List<int>() { subscriptionResponse.Subscription.Id.Value },
                        Include = ListSubscriptionComponentsInclude.Subscription
                    }
                );
            filteredComponentsResponse1.SubscriptionsComponents.Count.Should().Be(1);
            filteredComponentsResponse1.SubscriptionsComponents[0].ComponentId.Should()
                .Be(quantityComponentResponse.Component.Id);

            var filteredComponentsResponse2 =
                await _client.SubscriptionComponentsController.ListSubscriptionComponentsForSiteAsync(
                    new ListSubscriptionComponentsForSiteInput {
                        Filter = new ListSubscriptionComponentsForSiteFilter {
                            Subscription = new SubscriptionFilter {
                                DateField = SubscriptionListDateField.UpdatedAt,
                                EndDate = DateTime.Today.AddYears(-1)
                            }
                        },
                        ProductFamilyIds = new List<int>() { productFamilyId.Value },
                        SubscriptionIds = new List<int>() { subscriptionResponse.Subscription.Id.Value },
                        Include = ListSubscriptionComponentsInclude.Subscription
                    }
                );
            filteredComponentsResponse2.SubscriptionsComponents.Count.Should().Be(0);
        }

        [Fact]
        public async Task AllocateComponents_DoubleQuantityForAllocations_UpgradeChargeProratedQualityCanBeRead()
        {
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

            var randomString = TestUtils.GenerateRandomString(6);

            var quantityComponent = new QuantityBasedComponent($"widget{randomString}", $"widget {randomString}",
                PricingScheme.PerUnit, unitPrice: QuantityBasedComponentUnitPrice.FromString("10,23"),
                allowFractionalQuantities: true);

            var quantityComponentResponse = await _client.ComponentsController.CreateQuantityBasedComponentAsync(
                productFamilyId.ToString(),
                new CreateQuantityBasedComponent(quantityComponent));

            quantityComponentResponse.Component.Id.Should().NotBeNull();

            var onOffComponent = new OnOffComponent($"247Support{randomString}",
                unitPrice: OnOffComponentUnitPrice.FromString("100"));

            var onOffComponentResponse = await _client.ComponentsController
                .CreateOnOffComponentAsync(productFamilyId.ToString(), new CreateOnOffComponent(onOffComponent));

            onOffComponentResponse.Component.Id.Should().NotBeNull();

            const double quantityAmount = 10.6;
            const int onOffAmount = 1;

            var allocationsList = new List<CreateAllocation>()
            {
                new(quantityAmount, quantityComponentResponse.Component.Id),
                new(onOffAmount, onOffComponentResponse.Component.Id)
            };

            var allocationsPreview = await _client.SubscriptionComponentsController.PreviewAllocationsAsync(
                (int)subscriptionResponse.Subscription.Id, new PreviewAllocationsRequest(allocationsList));

            allocationsPreview.AllocationPreview.PeriodType.Should().BeEquivalentTo("prorated");

            var allocationPreviewItem =
                allocationsPreview.AllocationPreview.Allocations.FirstOrDefault(x =>
                    x.ComponentId == quantityComponentResponse.Component.Id);

            allocationPreviewItem.Should().NotBeNull();

            allocationPreviewItem?.UpgradeCharge.Should().Be(CreditType.Prorated);

            var quantityPreviewValue = allocationPreviewItem.Quantity.Match(Convert.ToDouble, double.Parse);
            quantityPreviewValue.Should().Be(quantityAmount);

            var allocationResponses = await _client.SubscriptionComponentsController.AllocateComponentsAsync(
                (int)subscriptionResponse.Subscription.Id, new AllocateComponents(allocations: allocationsList));

            var allocation = allocationResponses.FirstOrDefault(x =>
                x.Allocation.ComponentId == quantityComponentResponse.Component.Id)
                ?.Allocation;

            allocation.Should().NotBeNull();

            allocation.UpgradeCharge.Should().Be(CreditType.Prorated);

            var quantityAllocationValue = allocation.Quantity.Match(Convert.ToDouble, double.Parse);

            quantityAllocationValue.Should().Be(quantityPreviewValue);

            await CleanupUtils.ExecuteBasicSubscriptionCleanup(subscriptionResponse, customerResponse, paymentProfileId,
                productResponse, _client);

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ComponentsController.ArchiveComponentAsync((int)productFamilyId,
                    quantityComponentResponse.Component.Id.ToString());
            });

            await ErrorSuppressionWrapper.RunAsync(async () =>
            {
                await _client.ComponentsController.ArchiveComponentAsync((int)productFamilyId,
                    onOffComponentResponse.Component.Id.ToString());
            });
        }
    }
}
