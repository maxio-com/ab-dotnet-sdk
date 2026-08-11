
# Apple Pay Payment Profile

## Structure

`ApplePayPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The Chargify-assigned ID of the Apple Pay payment profile. |
| `FirstName` | `string` | Optional | The first name of the Apple Pay account holder |
| `LastName` | `string` | Optional | The last name of the Apple Pay account holder |
| `CustomerId` | `int?` | Optional | The Chargify-assigned ID for the customer record to which the Apple Pay account belongs |
| `CurrentVault` | [`ApplePayVault?`](../../doc/models/apple-pay-vault.md) | Optional | The vault that stores the payment profile with the provided vault_token. |
| `VaultToken` | `string` | Optional | The “token” provided by your vault storage for an already stored payment profile |
| `BillingAddress` | `string` | Optional | The current billing street address for the Apple Pay account |
| `BillingCity` | `string` | Optional | The current billing address city for the Apple Pay account |
| `BillingState` | `string` | Optional | The current billing address state for the Apple Pay account |
| `BillingZip` | `string` | Optional | The current billing address zip code for the Apple Pay account |
| `BillingCountry` | `string` | Optional | The current billing address country for the Apple Pay account |
| `CustomerVaultToken` | `string` | Optional | - |
| `BillingAddress2` | `string` | Optional | The current billing street address, second line, for the Apple Pay account |
| `PaymentType` | [`PaymentType`](../../doc/models/payment-type.md) | Required | **Default**: `PaymentType.apple_pay` |
| `SiteGatewaySettingId` | `int?` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | A timestamp indicating when this payment profile was created |
| `UpdatedAt` | `DateTimeOffset?` | Optional | A timestamp indicating when this payment profile was last updated |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ApplePayPaymentProfile applePayPaymentProfile = new ApplePayPaymentProfile
{
    PaymentType = PaymentType.ApplePay,
    Id = 252,
    FirstName = "first_name0",
    LastName = "last_name8",
    CustomerId = 34,
    CurrentVault = ApplePayVault.BraintreeBlue,
};
```

