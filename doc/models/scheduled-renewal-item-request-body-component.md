
# Scheduled Renewal Item Request Body Component

## Structure

`ScheduledRenewalItemRequestBodyComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ItemType` | `string` | Required, Constant | Item type to add. Either Product or Component.<br><br>**Value**: `"Component"` |
| `ItemId` | `int` | Required | Product or component identifier. |
| `PricePointId` | `int?` | Optional | Price point identifier. |
| `Quantity` | `int?` | Optional | (Optional) Quantity for the item. |
| `CustomPrice` | [`ScheduledRenewalComponentCustomPrice`](../../doc/models/scheduled-renewal-component-custom-price.md) | Optional | Custom pricing for a component within a scheduled renewal. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

ScheduledRenewalItemRequestBodyComponent scheduledRenewalItemRequestBodyComponent = new ScheduledRenewalItemRequestBodyComponent
{
    ItemType = "Component",
    ItemId = 20,
    PricePointId = 6,
    Quantity = 84,
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
};
```

