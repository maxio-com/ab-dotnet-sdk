
# List Subscription Group Prepayment

## Structure

`ListSubscriptionGroupPrepayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayment` | [`ListSubscriptionGroupPrepaymentItem`](../../doc/models/list-subscription-group-prepayment-item.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListSubscriptionGroupPrepayment listSubscriptionGroupPrepayment = new ListSubscriptionGroupPrepayment
{
    Prepayment = new ListSubscriptionGroupPrepaymentItem
    {
        Id = 38,
        SubscriptionGroupUid = "subscription_group_uid2",
        AmountInCents = 124L,
        RemainingAmountInCents = 182L,
        Details = "details8",
    },
};
```

