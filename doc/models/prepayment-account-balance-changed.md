
# Prepayment Account Balance Changed

## Structure

`PrepaymentAccountBalanceChanged`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | - |
| `PrepaymentAccountBalanceInCents` | `long` | Required | - |
| `PrepaymentBalanceChangeInCents` | `long` | Required | - |
| `CurrencyCode` | `string` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PrepaymentAccountBalanceChanged prepaymentAccountBalanceChanged = new PrepaymentAccountBalanceChanged
{
    Reason = "reason8",
    PrepaymentAccountBalanceInCents = 134L,
    PrepaymentBalanceChangeInCents = 158L,
    CurrencyCode = "currency_code8",
};
```

