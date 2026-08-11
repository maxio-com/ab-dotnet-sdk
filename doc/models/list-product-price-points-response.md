
# List Product Price Points Response

## Structure

`ListProductPricePointsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<ProductPricePoint>`](../../doc/models/product-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListProductPricePointsResponse listProductPricePointsResponse = new ListProductPricePointsResponse
{
    PricePoints = new List<ProductPricePoint>
    {
        new ProductPricePoint
        {
            Id = 40,
            Name = "name2",
            Handle = "handle8",
            PriceInCents = 108L,
            Interval = 92,
        },
    },
};
```

