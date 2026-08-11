
# Update Subscription Component

## Structure

`UpdateSubscriptionComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | `int?` | Optional | - |
| `CustomPrice` | [`ComponentCustomPrice`](../../doc/models/component-custom-price.md) | Optional | Create or update custom pricing unique to the subscription. Used in place of `price_point_id`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

UpdateSubscriptionComponent updateSubscriptionComponent = new UpdateSubscriptionComponent
{
    ComponentId = 118,
    CustomPrice = new ComponentCustomPrice
    {
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
        PricingScheme = PricingScheme.Stairstep,
        Interval = 66,
        IntervalUnit = IntervalUnit.Day,
        ListPricePointId = 174,
    },
};
```

