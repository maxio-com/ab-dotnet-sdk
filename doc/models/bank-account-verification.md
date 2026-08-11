
# Bank Account Verification

## Structure

`BankAccountVerification`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Deposit1InCents` | `long?` | Optional | - |
| `Deposit2InCents` | `long?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

BankAccountVerification bankAccountVerification = new BankAccountVerification
{
    Deposit1InCents = 248L,
    Deposit2InCents = 10L,
};
```

