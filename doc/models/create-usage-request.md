
# Create Usage Request

## Structure

`CreateUsageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Usage` | [`CreateUsage`](../../doc/models/create-usage.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateUsageRequest createUsageRequest = new CreateUsageRequest
{
    Usage = new CreateUsage
    {
        Quantity = 162.34,
        PricePointId = "price_point_id0",
        Memo = "memo2",
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
    },
};
```

