
# Bulk Create Product Price Points Response

## Structure

`BulkCreateProductPricePointsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<ProductPricePoint>`](../../doc/models/product-price-point.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

BulkCreateProductPricePointsResponse bulkCreateProductPricePointsResponse = new BulkCreateProductPricePointsResponse
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
        new ProductPricePoint
        {
            Id = 40,
            Name = "name2",
            Handle = "handle8",
            PriceInCents = 108L,
            Interval = 92,
        },
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

