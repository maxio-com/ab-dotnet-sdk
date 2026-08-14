
# Product Price Point Response

## Structure

`ProductPricePointResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`ProductPricePoint`](../../doc/models/product-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProductPricePointResponse productPricePointResponse = new ProductPricePointResponse
{
    PricePoint = new ProductPricePoint
    {
        Id = 248,
        Name = "name0",
        Handle = "handle6",
        PriceInCents = 196L,
        Interval = 44,
    },
};
```

