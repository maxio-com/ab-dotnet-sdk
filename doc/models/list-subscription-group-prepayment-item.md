
# List Subscription Group Prepayment Item

## Structure

`ListSubscriptionGroupPrepaymentItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `SubscriptionGroupUid` | `string` | Optional | - |
| `AmountInCents` | `long?` | Optional | - |
| `RemainingAmountInCents` | `long?` | Optional | - |
| `Details` | `string` | Optional | - |
| `External` | `bool?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `PaymentType` | [`PrepaymentMethod?`](../../doc/models/prepayment-method.md) | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListSubscriptionGroupPrepaymentItem listSubscriptionGroupPrepaymentItem = new ListSubscriptionGroupPrepaymentItem
{
    Id = 72,
    SubscriptionGroupUid = "subscription_group_uid6",
    AmountInCents = 98L,
    RemainingAmountInCents = 216L,
    Details = "details2",
};
```

