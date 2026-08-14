
# Create or Update Product Request

## Structure

`CreateOrUpdateProductRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Product` | [`CreateOrUpdateProduct`](../../doc/models/create-or-update-product.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateOrUpdateProductRequest createOrUpdateProductRequest = new CreateOrUpdateProductRequest
{
    Product = new CreateOrUpdateProduct
    {
        Name = "name0",
        Description = "description0",
        PriceInCents = 54L,
        Interval = 186,
        IntervalUnit = IntervalUnit.Day,
        Handle = "handle6",
        AccountingCode = "accounting_code6",
        RequireCreditCard = false,
        TrialPriceInCents = 34L,
        TrialInterval = 88,
    },
};
```

