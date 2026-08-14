
# Subscription Group Prepayment Request

## Structure

`SubscriptionGroupPrepaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayment` | [`SubscriptionGroupPrepayment`](../../doc/models/subscription-group-prepayment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupPrepaymentRequest subscriptionGroupPrepaymentRequest = new SubscriptionGroupPrepaymentRequest
{
    Prepayment = new SubscriptionGroupPrepayment
    {
        Amount = 136,
        Details = "details8",
        Memo = "memo2",
        Method = SubscriptionGroupPrepaymentMethod.PaypalAccount,
    },
};
```

