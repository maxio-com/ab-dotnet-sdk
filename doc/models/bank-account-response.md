
# Bank Account Response

## Structure

`BankAccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentProfile` | [`BankAccountPaymentProfile`](../../doc/models/bank-account-payment-profile.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

BankAccountResponse bankAccountResponse = new BankAccountResponse
{
    PaymentProfile = new BankAccountPaymentProfile
    {
        PaymentType = PaymentType.BankAccount,
        Id = 44,
        FirstName = "first_name4",
        LastName = "last_name2",
        CustomerId = 82,
        CurrentVault = BankAccountVault.Authorizenet,
        Verified = false,
    },
};
```

