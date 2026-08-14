
# Create Product Price Point Request

## Structure

`CreateProductPricePointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`CreateProductPricePoint`](../../doc/models/create-product-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateProductPricePointRequest createProductPricePointRequest = new CreateProductPricePointRequest
{
    PricePoint = new CreateProductPricePoint
    {
        Name = "name0",
        PriceInCents = 196L,
        Interval = 44,
        IntervalUnit = IntervalUnit.Day,
        Handle = "handle6",
        TrialPriceInCents = 108L,
        TrialInterval = 202,
        TrialIntervalUnit = IntervalUnit.Day,
        TrialType = TrialType.NoObligation,
        UseSiteExchangeRate = true,
    },
};
```

