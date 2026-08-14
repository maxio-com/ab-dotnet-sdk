
# Subscription Group Credit Card

## Structure

`SubscriptionGroupCreditCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargifyToken` | `string` | Optional | - |
| `VaultToken` | `string` | Optional | - |
| `CurrentVault` | [`CreditCardVault?`](../../doc/models/credit-card-vault.md) | Optional | The vault that stores the payment profile with the provided `vault_token`. Use `bogus` for testing. |
| `GatewayHandle` | `string` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `BillingAddress` | `string` | Optional | - |
| `BillingAddress2` | `string` | Optional | - |
| `BillingCity` | `string` | Optional | - |
| `BillingState` | `string` | Optional | - |
| `BillingZip` | `string` | Optional | - |
| `BillingCountry` | `string` | Optional | - |
| `FullNumber` | [`SubscriptionGroupCreditCardFullNumber`](../../doc/models/containers/subscription-group-credit-card-full-number.md) | Optional | This is a container for one-of cases. |
| `ExpirationMonth` | [`SubscriptionGroupCreditCardExpirationMonth`](../../doc/models/containers/subscription-group-credit-card-expiration-month.md) | Optional | This is a container for one-of cases. |
| `ExpirationYear` | [`SubscriptionGroupCreditCardExpirationYear`](../../doc/models/containers/subscription-group-credit-card-expiration-year.md) | Optional | This is a container for one-of cases. |
| `LastFour` | `string` | Optional | - |
| `CardType` | [`CardType?`](../../doc/models/card-type.md) | Optional | The type of card used. |
| `CustomerVaultToken` | `string` | Optional | - |
| `Cvv` | `string` | Optional | - |
| `PaymentType` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

SubscriptionGroupCreditCard subscriptionGroupCreditCard = new SubscriptionGroupCreditCard
{
    ChargifyToken = "tok_592nf92ng0sjd4300p",
    VaultToken = "vault_token0",
    CurrentVault = CreditCardVault.BlueSnap,
    GatewayHandle = "gateway_handle0",
    FirstName = "first_name8",
    FullNumber = SubscriptionGroupCreditCardFullNumber.FromNumber(4111111111111111),
};
```

