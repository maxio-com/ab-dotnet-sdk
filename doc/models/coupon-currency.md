
# Coupon Currency

## Structure

`CouponCurrency`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Price` | `double?` | Optional | - |
| `CouponId` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CouponCurrency couponCurrency = new CouponCurrency
{
    Id = 202,
    Currency = "currency0",
    Price = 14.62,
    CouponId = 184,
};
```

