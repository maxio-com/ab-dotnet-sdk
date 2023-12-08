
# Credit Card Payment Profile

## Structure

`CreditCardPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `MaskedCardNumber` | `string` | Required | - |
| `CardType` | [`CardType1?`](../../doc/models/card-type-1.md) | Optional | - |
| `ExpirationMonth` | `int?` | Optional | - |
| `ExpirationYear` | `int?` | Optional | - |
| `CustomerId` | `int?` | Optional | - |
| `CurrentVault` | [`CurrentVault?`](../../doc/models/current-vault.md) | Optional | The vault that stores the payment profile with the provided `vault_token`. Use `bogus` for testing. |
| `VaultToken` | `string` | Optional | - |
| `BillingAddress` | `string` | Optional | - |
| `BillingCity` | `string` | Optional | - |
| `BillingState` | `string` | Optional | - |
| `BillingZip` | `string` | Optional | - |
| `BillingCountry` | `string` | Optional | - |
| `CustomerVaultToken` | `string` | Optional | - |
| `BillingAddress2` | `string` | Optional | - |
| `PaymentType` | `string` | Optional | - |
| `Disabled` | `bool?` | Optional | - |
| `SiteGatewaySettingId` | `int?` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": 252,
  "first_name": "first_name0",
  "last_name": "last_name8",
  "masked_card_number": "masked_card_number8",
  "card_type": "synchrony",
  "expiration_month": 170
}
```

