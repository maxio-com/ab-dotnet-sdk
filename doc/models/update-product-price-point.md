
# Update Product Price Point

## Structure

`UpdateProductPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Handle` | `string` | Optional | - |
| `PriceInCents` | `long?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateProductPricePoint updateProductPricePoint = new UpdateProductPricePoint
{
    Handle = "handle2",
    PriceInCents = 154L,
};
```

