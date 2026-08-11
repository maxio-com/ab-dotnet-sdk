
# Coupon Restriction

## Structure

`CouponRestriction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `ItemType` | [`RestrictionType?`](../../doc/models/restriction-type.md) | Optional | - |
| `ItemId` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CouponRestriction couponRestriction = new CouponRestriction
{
    Id = 66,
    ItemType = RestrictionType.Component,
    ItemId = 214,
    Name = "name0",
    Handle = "handle6",
};
```

