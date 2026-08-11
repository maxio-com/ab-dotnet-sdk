
# Update Product Price Point Request

## Structure

`UpdateProductPricePointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`UpdateProductPricePoint`](../../doc/models/update-product-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateProductPricePointRequest updateProductPricePointRequest = new UpdateProductPricePointRequest
{
    PricePoint = new UpdateProductPricePoint
    {
        Handle = "handle6",
        PriceInCents = 196L,
    },
};
```

