
# Create Component Price Points Request

## Structure

`CreateComponentPricePointsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<CreateComponentPricePointsRequestPricePoints>`](../../doc/models/containers/create-component-price-points-request-price-points.md) | Required | This is List of a container for any-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateComponentPricePointsRequest createComponentPricePointsRequest = new CreateComponentPricePointsRequest
{
    PricePoints = new List<CreateComponentPricePointsRequestPricePoints>
    {
        CreateComponentPricePointsRequestPricePoints.FromCreateComponentPricePoint(
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
                Handle = "handle6",
                UseSiteExchangeRate = false,
                TaxIncluded = false,
                Interval = 24,
                IntervalUnit = IntervalUnit.Day,
            }
        ),
    },
};
```

