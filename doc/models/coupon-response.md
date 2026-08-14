
# Coupon Response

## Structure

`CouponResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Coupon` | [`Coupon`](../../doc/models/coupon.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CouponResponse couponResponse = new CouponResponse
{
    Coupon = new Coupon
    {
        Id = 196,
        Name = "name4",
        Code = "code2",
        Description = "description6",
        Amount = 97.66,
    },
};
```

