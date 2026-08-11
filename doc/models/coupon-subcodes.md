
# Coupon Subcodes

## Structure

`CouponSubcodes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Codes` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CouponSubcodes couponSubcodes = new CouponSubcodes
{
    Codes = new List<string>
    {
        "codes8",
        "codes9",
    },
};
```

