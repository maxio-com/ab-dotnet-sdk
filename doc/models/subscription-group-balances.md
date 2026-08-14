
# Subscription Group Balances

## Structure

`SubscriptionGroupBalances`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayments` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | - |
| `ServiceCredits` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | - |
| `OpenInvoices` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | - |
| `PendingDiscounts` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupBalances subscriptionGroupBalances = new SubscriptionGroupBalances
{
    Prepayments = new AccountBalance
    {
        BalanceInCents = 192L,
        AutomaticBalanceInCents = 178L,
        RemittanceBalanceInCents = 146L,
    },
    ServiceCredits = new AccountBalance
    {
        BalanceInCents = 84L,
        AutomaticBalanceInCents = 70L,
        RemittanceBalanceInCents = 38L,
    },
    OpenInvoices = new AccountBalance
    {
        BalanceInCents = 40L,
        AutomaticBalanceInCents = 202L,
        RemittanceBalanceInCents = 170L,
    },
    PendingDiscounts = new AccountBalance
    {
        BalanceInCents = 88L,
        AutomaticBalanceInCents = 154L,
        RemittanceBalanceInCents = 134L,
    },
};
```

