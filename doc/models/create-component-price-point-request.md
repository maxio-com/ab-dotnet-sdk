
# Create Component Price Point Request

## Structure

`CreateComponentPricePointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`CreateComponentPricePointRequestPricePoint`](../../doc/models/containers/create-component-price-point-request-price-point.md) | Required | This is a container for any-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateComponentPricePointRequest createComponentPricePointRequest = new CreateComponentPricePointRequest
{
    PricePoint = CreateComponentPricePointRequestPricePoint.FromCreateComponentPricePoint(
        new CreateComponentPricePoint
        {
            Name = "name0",
            PricingScheme = PricingScheme.PerUnit,
            Prices = new List<Price>
            {
                new Price
                {
                    StartingQuantity = PriceStartingQuantity.FromNumber(242),
                    UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                    EndingQuantity = PriceEndingQuantity.FromNumber(40),
                },
            },
            Handle = "handle6",
            UseSiteExchangeRate = true,
            TaxIncluded = false,
            Interval = 24,
            IntervalUnit = IntervalUnit.Day,
        }
    ),
};
```

