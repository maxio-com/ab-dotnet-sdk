
# Add Coupons Request

## Structure

`AddCouponsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Codes` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

AddCouponsRequest addCouponsRequest = new AddCouponsRequest
{
    Codes = new List<string>
    {
        "codes6",
        "codes7",
    },
};
```

