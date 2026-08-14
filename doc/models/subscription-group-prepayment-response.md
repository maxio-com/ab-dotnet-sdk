
# Subscription Group Prepayment Response

## Structure

`SubscriptionGroupPrepaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `AmountInCents` | `long?` | Optional | The amount in cents of the entry. |
| `EndingBalanceInCents` | `long?` | Optional | The ending balance in cents of the account. |
| `EntryType` | [`ServiceCreditType?`](../../doc/models/service-credit-type.md) | Optional | The type of entry |
| `Memo` | `string` | Optional | A memo attached to the entry. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupPrepaymentResponse subscriptionGroupPrepaymentResponse = new SubscriptionGroupPrepaymentResponse
{
    Id = 32,
    AmountInCents = 138L,
    EndingBalanceInCents = 158L,
    EntryType = ServiceCreditType.Credit,
    Memo = "memo2",
};
```

