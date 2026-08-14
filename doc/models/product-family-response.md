
# Product Family Response

## Structure

`ProductFamilyResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductFamily` | [`ProductFamily`](../../doc/models/product-family.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProductFamilyResponse productFamilyResponse = new ProductFamilyResponse
{
    ProductFamily = new ProductFamily
    {
        Id = 14,
        Name = "name0",
        Handle = "handle6",
        AccountingCode = "accounting_code6",
        Description = "description0",
    },
};
```

