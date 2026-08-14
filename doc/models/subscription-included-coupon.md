
# Subscription Included Coupon

## Structure

`SubscriptionIncludedCoupon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | - |
| `UseCount` | `int?` | Optional | - |
| `UsesAllowed` | `int?` | Optional | - |
| `ExpiresAt` | `string` | Optional | - |
| `Recurring` | `bool?` | Optional | - |
| `AmountInCents` | `long?` | Optional | **Constraints**: `>= 0` |
| `Percentage` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionIncludedCoupon subscriptionIncludedCoupon = new SubscriptionIncludedCoupon
{
    Code = "\"ABCD_10\"",
    UseCount = 2,
    UsesAllowed = 10,
    ExpiresAt = "\"2023-07-13T05:18:58-04:00\"",
    Recurring = false,
    AmountInCents = 1000L,
    Percentage = "\"15.0\"",
};
```

