
# Get One Time Token Payment Profile

## Structure

`GetOneTimeTokenPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `FirstName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `LastName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `MaskedCardNumber` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `CardType` | [`CardType`](../../doc/models/card-type.md) | Required | The type of card used. |
| `ExpirationMonth` | `double` | Required | - |
| `ExpirationYear` | `double` | Required | - |
| `CustomerId` | `string` | Optional | - |
| `CurrentVault` | [`CreditCardVault`](../../doc/models/credit-card-vault.md) | Required | The vault that stores the payment profile with the provided `vault_token`. Use `bogus` for testing. |
| `VaultToken` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingAddress` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingAddress2` | `string` | Optional | - |
| `BillingCity` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingCountry` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingState` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `BillingZip` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PaymentType` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `Disabled` | `bool` | Required | - |
| `SiteGatewaySettingId` | `int` | Required | - |
| `CustomerVaultToken` | `string` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

GetOneTimeTokenPaymentProfile getOneTimeTokenPaymentProfile = new GetOneTimeTokenPaymentProfile
{
    FirstName = "first_name4",
    LastName = "last_name2",
    MaskedCardNumber = "masked_card_number2",
    CardType = CardType.MaestroNoLuhn,
    ExpirationMonth = 28.3,
    ExpirationYear = 4.96,
    CurrentVault = CreditCardVault.TrustCommerce,
    VaultToken = "vault_token6",
    BillingAddress = "billing_address6",
    BillingCity = "billing_city2",
    BillingCountry = "billing_country8",
    BillingState = "billing_state2",
    BillingZip = "billing_zip2",
    PaymentType = "payment_type6",
    Disabled = false,
    SiteGatewaySettingId = 156,
    Id = "id4",
    CustomerId = "customer_id2",
    BillingAddress2 = "billing_address_26",
    CustomerVaultToken = "customer_vault_token2",
    GatewayHandle = "gateway_handle6",
};
```

