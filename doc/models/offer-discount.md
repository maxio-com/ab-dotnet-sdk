
# Offer Discount

## Structure

`OfferDiscount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CouponCode` | `string` | Optional | - |
| `CouponId` | `int?` | Optional | - |
| `CouponName` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

OfferDiscount offerDiscount = new OfferDiscount
{
    CouponCode = "coupon_code6",
    CouponId = 202,
    CouponName = "coupon_name6",
};
```

