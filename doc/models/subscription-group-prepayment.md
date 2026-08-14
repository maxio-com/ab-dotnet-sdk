
# Subscription Group Prepayment

## Structure

`SubscriptionGroupPrepayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int` | Required | - |
| `Details` | `string` | Required | - |
| `Memo` | `string` | Required | - |
| `Method` | [`SubscriptionGroupPrepaymentMethod`](../../doc/models/subscription-group-prepayment-method.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupPrepayment subscriptionGroupPrepayment = new SubscriptionGroupPrepayment
{
    Amount = 12,
    Details = "details4",
    Memo = "memo8",
    Method = SubscriptionGroupPrepaymentMethod.MoneyOrder,
};
```

