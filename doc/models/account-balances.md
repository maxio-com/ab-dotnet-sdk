
# Account Balances

## Structure

`AccountBalances`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OpenInvoices` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | The balance, in cents, of the sum of the subscription's open, payable invoices. |
| `PendingInvoices` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | The balance, in cents, of the sum of the subscription's pending, payable invoices. |
| `PendingDiscounts` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | The balance, in cents, of the subscription's Pending Discount account. |
| `ServiceCredits` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | The balance, in cents, of the subscription's Service Credit account. |
| `Prepayments` | [`AccountBalance`](../../doc/models/account-balance.md) | Optional | The balance, in cents, of the subscription's Prepayment account. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AccountBalances accountBalances = new AccountBalances
{
    OpenInvoices = new AccountBalance
    {
        BalanceInCents = 40L,
        AutomaticBalanceInCents = 202L,
        RemittanceBalanceInCents = 170L,
    },
    PendingInvoices = new AccountBalance
    {
        BalanceInCents = 0L,
        AutomaticBalanceInCents = 242L,
        RemittanceBalanceInCents = 46L,
    },
    PendingDiscounts = new AccountBalance
    {
        BalanceInCents = 88L,
        AutomaticBalanceInCents = 154L,
        RemittanceBalanceInCents = 134L,
    },
    ServiceCredits = new AccountBalance
    {
        BalanceInCents = 84L,
        AutomaticBalanceInCents = 70L,
        RemittanceBalanceInCents = 38L,
    },
    Prepayments = new AccountBalance
    {
        BalanceInCents = 192L,
        AutomaticBalanceInCents = 178L,
        RemittanceBalanceInCents = 146L,
    },
};
```

