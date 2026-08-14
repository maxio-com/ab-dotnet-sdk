
# Coupon Request

## Structure

`CouponRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Coupon` | [`CouponPayload`](../../doc/models/coupon-payload.md) | Optional | - |
| `RestrictedProducts` | `Dictionary<string, bool>` | Optional | An object where the keys are product IDs or handles (prefixed with 'handle:'), and the values are booleans indicating if the coupon should be applicable to the product. |
| `RestrictedComponents` | `Dictionary<string, bool>` | Optional | An object where the keys are component IDs or handles (prefixed with 'handle:'), and the values are booleans indicating if the coupon should be applicable to the component. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CouponRequest couponRequest = new CouponRequest
{
    Coupon = new CouponPayload
    {
        Name = "name4",
        Code = "code2",
        Description = "description6",
        Percentage = CouponPayloadPercentage.FromString("String3"),
        AmountInCents = 230L,
    },
    RestrictedProducts = new Dictionary<string, bool>
    {
        ["key0"] = true,
        ["key1"] = false,
    },
    RestrictedComponents = new Dictionary<string, bool>
    {
        ["key0"] = true,
        ["key1"] = false,
    },
};
```

