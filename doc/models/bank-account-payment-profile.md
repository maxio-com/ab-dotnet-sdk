
# Bank Account Payment Profile

## Structure

`BankAccountPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The Chargify-assigned ID of the stored bank account. This value can be used as an input to payment_profile_id when creating a subscription, in order to re-use a stored payment profile for the same customer |
| `FirstName` | `string` | Optional | The first name of the bank account holder |
| `LastName` | `string` | Optional | The last name of the bank account holder |
| `CustomerId` | `int?` | Optional | The Chargify-assigned id for the customer record to which the bank account belongs |
| `CurrentVault` | [`BankAccountVault?`](../../doc/models/bank-account-vault.md) | Optional | The vault that stores the payment profile with the provided vault_token. Use `bogus` for testing. |
| `VaultToken` | `string` | Optional | The “token” provided by your vault storage for an already stored payment profile |
| `BillingAddress` | `string` | Optional | The current billing street address for the bank account |
| `BillingCity` | `string` | Optional | The current billing address city for the bank account |
| `BillingState` | `string` | Optional | The current billing address state for the bank account |
| `BillingZip` | `string` | Optional | The current billing address zip code for the bank account |
| `BillingCountry` | `string` | Optional | The current billing address country for the bank account |
| `CustomerVaultToken` | `string` | Optional | (only for Authorize.Net CIM storage): the customerProfileId for the owner of the customerPaymentProfileId provided as the vault_token. |
| `BillingAddress2` | `string` | Optional | The current billing street address, second line, for the bank account |
| `BankName` | `string` | Optional | The bank where the account resides |
| `MaskedBankRoutingNumber` | `string` | Optional | A string representation of the stored bank routing number with all but the last 4 digits marked with X’s (i.e. ‘XXXXXXX1111’). payment_type will be bank_account |
| `MaskedBankAccountNumber` | `string` | Required | A string representation of the stored bank account number with all but the last 4 digits marked with X’s (i.e. ‘XXXXXXX1111’) |
| `BankAccountType` | [`BankAccountType?`](../../doc/models/bank-account-type.md) | Optional | Defaults to checking |
| `BankAccountHolderType` | [`BankAccountHolderType?`](../../doc/models/bank-account-holder-type.md) | Optional | Defaults to personal |
| `PaymentType` | [`PaymentType`](../../doc/models/payment-type.md) | Required | **Default**: `PaymentType.bank_account` |
| `Verified` | `bool?` | Optional | denotes whether a bank account has been verified by providing the amounts of two small deposits made into the account<br><br>**Default**: `false` |
| `SiteGatewaySettingId` | `int?` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | A timestamp indicating when this payment profile was created |
| `UpdatedAt` | `DateTimeOffset?` | Optional | A timestamp indicating when this payment profile was last updated |

## Example (as JSON)

```json
{
  "masked_bank_account_number": "masked_bank_account_number8",
  "payment_type": "bank_account",
  "verified": false,
  "id": 188,
  "first_name": "first_name6",
  "last_name": "last_name4",
  "customer_id": 226,
  "current_vault": "authorizenet"
}
```

