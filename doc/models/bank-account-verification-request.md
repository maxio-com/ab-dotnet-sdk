
# Bank Account Verification Request

## Structure

`BankAccountVerificationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAccountVerification` | [`BankAccountVerification`](../../doc/models/bank-account-verification.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

BankAccountVerificationRequest bankAccountVerificationRequest = new BankAccountVerificationRequest
{
    BankAccountVerification = new BankAccountVerification
    {
        Deposit1InCents = 244L,
        Deposit2InCents = 6L,
    },
};
```

