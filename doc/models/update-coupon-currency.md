
# Update Coupon Currency

## Structure

`UpdateCouponCurrency`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | ISO code for the site defined currency. |
| `Price` | `int` | Required | Price for the given currency. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateCouponCurrency updateCouponCurrency = new UpdateCouponCurrency
{
    Currency = "currency4",
    Price = 100,
};
```

