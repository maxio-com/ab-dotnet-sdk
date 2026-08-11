
# Scheduled Renewal Configuration Item Request

## Structure

`ScheduledRenewalConfigurationItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RenewalConfigurationItem` | [`ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem`](../../doc/models/containers/scheduled-renewal-configuration-item-request-renewal-configuration-item.md) | Required | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

ScheduledRenewalConfigurationItemRequest scheduledRenewalConfigurationItemRequest = new ScheduledRenewalConfigurationItemRequest
{
    RenewalConfigurationItem = ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(
        new ScheduledRenewalItemRequestBodyComponent
        {
            ItemType = "Component",
            ItemId = 108,
            PricePointId = 122,
            Quantity = 212,
            CustomPrice = new ScheduledRenewalComponentCustomPrice
            {
                PricingScheme = PricingScheme.Stairstep,
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(242),
                        UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                        EndingQuantity = PriceEndingQuantity.FromNumber(40),
                    },
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(242),
                        UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                        EndingQuantity = PriceEndingQuantity.FromNumber(40),
                    },
                },
                TaxIncluded = false,
            },
        }
    ),
};
```

