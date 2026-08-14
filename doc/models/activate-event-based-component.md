
# Activate Event Based Component

## Structure

`ActivateEventBasedComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePointId` | `int?` | Optional | The Chargify id of the price point |
| `BillingSchedule` | [`BillingSchedule`](../../doc/models/billing-schedule.md) | Optional | Billing schedule settings for component allocations or usages on multi-frequency subscriptions. Use this to start a component's billing period on a custom date instead of aligning with the product charge schedule. |
| `CustomPrice` | [`ComponentCustomPrice`](../../doc/models/component-custom-price.md) | Optional | Create or update custom pricing unique to the subscription. Used in place of `price_point_id`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

ActivateEventBasedComponent activateEventBasedComponent = new ActivateEventBasedComponent
{
    PricePointId = 68,
    BillingSchedule = new BillingSchedule
    {
        InitialBillingAt = DateTime.Parse("2016-03-13"),
    },
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

