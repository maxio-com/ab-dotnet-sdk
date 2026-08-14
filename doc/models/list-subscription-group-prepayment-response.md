
# List Subscription Group Prepayment Response

## Structure

`ListSubscriptionGroupPrepaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayments` | [`List<ListSubscriptionGroupPrepayment>`](../../doc/models/list-subscription-group-prepayment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListSubscriptionGroupPrepaymentResponse listSubscriptionGroupPrepaymentResponse = new ListSubscriptionGroupPrepaymentResponse
{
    Prepayments = new List<ListSubscriptionGroupPrepayment>
    {
        new ListSubscriptionGroupPrepayment
        {
            Prepayment = new ListSubscriptionGroupPrepaymentItem
            {
                Id = 38,
                SubscriptionGroupUid = "subscription_group_uid2",
                AmountInCents = 124L,
                RemainingAmountInCents = 182L,
                Details = "details8",
            },
        },
    },
};
```

