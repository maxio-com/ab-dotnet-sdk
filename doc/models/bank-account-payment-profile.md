
# Bank Account Payment Profile

## Structure

`BankAccountPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `CustomerId` | `int?` | Optional | - |
| `CurrentVault` | [`BankAccountVault?`](../../doc/models/bank-account-vault.md) | Optional | The vault that stores the payment profile with the provided vault_token. |
| `VaultToken` | `string` | Optional | - |
| `BillingAddress` | `string` | Optional | - |
| `BillingCity` | `string` | Optional | - |
| `BillingState` | `string` | Optional | - |
| `BillingZip` | `string` | Optional | - |
| `BillingCountry` | `string` | Optional | - |
| `CustomerVaultToken` | `string` | Optional | - |
| `BillingAddress2` | `string` | Optional | - |
| `BankName` | `string` | Optional | - |
| `MaskedBankRoutingNumber` | `string` | Required | - |
| `MaskedBankAccountNumber` | `string` | Required | - |
| `BankAccountType` | `string` | Optional | - |
| `BankAccountHolderType` | `string` | Optional | - |
| `PaymentType` | `string` | Optional | - |
| `Verified` | `bool?` | Optional | denotes whether a bank account has been verified by providing the amounts of two small deposits made into the account<br>**Default**: `false` |
| `SiteGatewaySettingId` | `int?` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "masked_bank_routing_number": "masked_bank_routing_number8",
  "masked_bank_account_number": "masked_bank_account_number8",
  "verified": false,
  "id": 188,
  "first_name": "first_name6",
  "last_name": "last_name4",
  "customer_id": 226,
  "current_vault": "authorizenet"
}
```

