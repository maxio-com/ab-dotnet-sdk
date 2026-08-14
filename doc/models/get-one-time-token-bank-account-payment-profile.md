
# Get One Time Token Bank Account Payment Profile

## Structure

`GetOneTimeTokenBankAccountPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `FirstName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `LastName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `CustomerId` | `string` | Optional | - |
| `CurrentVault` | [`BankAccountVault`](../../doc/models/bank-account-vault.md) | Required | The vault that stores the payment profile with the provided vault_token. Use `bogus` for testing. |
| `VaultToken` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingAddress` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingAddress2` | `string` | Optional | - |
| `BillingCity` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingCountry` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingState` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingZip` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BankName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `MaskedBankRoutingNumber` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `MaskedBankAccountNumber` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BankAccountType` | [`BankAccountType`](../../doc/models/bank-account-type.md) | Required | Defaults to checking |
| `BankAccountHolderType` | [`BankAccountHolderType`](../../doc/models/bank-account-holder-type.md) | Required | Defaults to personal |
| `PaymentType` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Disabled` | `bool` | Required | - |
| `SiteGatewaySettingId` | `int` | Required | - |
| `CustomerVaultToken` | `string` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |
| `Verified` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

GetOneTimeTokenBankAccountPaymentProfile getOneTimeTokenBankAccountPaymentProfile = new GetOneTimeTokenBankAccountPaymentProfile
{
    FirstName = "first_name0",
    LastName = "last_name8",
    CurrentVault = BankAccountVault.Maxp,
    VaultToken = "vault_token2",
    BillingAddress = "billing_address2",
    BillingCity = "billing_city8",
    BillingCountry = "billing_country4",
    BillingState = "billing_state6",
    BillingZip = "billing_zip8",
    BankName = "bank_name4",
    MaskedBankRoutingNumber = "masked_bank_routing_number4",
    MaskedBankAccountNumber = "masked_bank_account_number2",
    BankAccountType = BankAccountType.Checking,
    BankAccountHolderType = BankAccountHolderType.Personal,
    PaymentType = "payment_type0",
    Disabled = false,
    SiteGatewaySettingId = 246,
    Id = "id0",
    CustomerId = "customer_id8",
    BillingAddress2 = "billing_address_22",
    CustomerVaultToken = "customer_vault_token8",
    GatewayHandle = "gateway_handle2",
};
```

