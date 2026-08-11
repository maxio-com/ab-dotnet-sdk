
# Account Balance

## Structure

`AccountBalance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BalanceInCents` | `long?` | Optional | The balance in cents. |
| `AutomaticBalanceInCents` | `long?` | Optional | The automatic balance in cents. |
| `RemittanceBalanceInCents` | `long?` | Optional | The remittance balance in cents. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AccountBalance accountBalance = new AccountBalance
{
    BalanceInCents = 242L,
    AutomaticBalanceInCents = 0L,
    RemittanceBalanceInCents = 32L,
};
```

