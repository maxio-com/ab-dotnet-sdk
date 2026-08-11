
# Create Product Family Request

## Structure

`CreateProductFamilyRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductFamily` | [`CreateProductFamily`](../../doc/models/create-product-family.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateProductFamilyRequest createProductFamilyRequest = new CreateProductFamilyRequest
{
    ProductFamily = new CreateProductFamily
    {
        Name = "name0",
        Handle = "handle6",
        Description = "description0",
        Surcharging = false,
    },
};
```

