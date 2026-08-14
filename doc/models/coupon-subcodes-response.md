
# Coupon Subcodes Response

## Structure

`CouponSubcodesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreatedCodes` | `List<string>` | Optional | - |
| `DuplicateCodes` | `List<string>` | Optional | - |
| `InvalidCodes` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CouponSubcodesResponse couponSubcodesResponse = new CouponSubcodesResponse
{
    CreatedCodes = new List<string>
    {
        "created_codes7",
    },
    DuplicateCodes = new List<string>
    {
        "duplicate_codes8",
    },
    InvalidCodes = new List<string>
    {
        "invalid_codes4",
        "invalid_codes3",
    },
};
```

