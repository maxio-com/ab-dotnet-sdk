
# Product Response

## Structure

`ProductResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Product` | [`Product`](../../doc/models/product.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProductResponse productResponse = new ProductResponse
{
    Product = new Product
    {
        Id = 134,
        Name = "name0",
        Handle = "handle6",
        Description = "description0",
        AccountingCode = "accounting_code6",
    },
};
```

