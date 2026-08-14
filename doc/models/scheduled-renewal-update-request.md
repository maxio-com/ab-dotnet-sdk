
# Scheduled Renewal Update Request

## Structure

`ScheduledRenewalUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RenewalConfigurationItem` | [`ScheduledRenewalUpdateRequestRenewalConfigurationItem`](../../doc/models/containers/scheduled-renewal-update-request-renewal-configuration-item.md) | Required | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

ScheduledRenewalUpdateRequest scheduledRenewalUpdateRequest = new ScheduledRenewalUpdateRequest
{
    RenewalConfigurationItem = ScheduledRenewalUpdateRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(
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

