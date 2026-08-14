
# Bulk Create Product Price Points Request

## Structure

`BulkCreateProductPricePointsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<CreateProductPricePoint>`](../../doc/models/create-product-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

BulkCreateProductPricePointsRequest bulkCreateProductPricePointsRequest = new BulkCreateProductPricePointsRequest
{
    PricePoints = new List<CreateProductPricePoint>
    {
        new CreateProductPricePoint
        {
            Name = "name2",
            PriceInCents = 108L,
            Interval = 92,
            IntervalUnit = IntervalUnit.Day,
            Handle = "handle8",
            TrialPriceInCents = 196L,
            TrialInterval = 250,
            TrialIntervalUnit = IntervalUnit.Day,
            TrialType = TrialType.NoObligation,
            UseSiteExchangeRate = true,
        },
    },
};
```

