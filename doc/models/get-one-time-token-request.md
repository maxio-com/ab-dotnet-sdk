
# Get One Time Token Request

## Structure

`GetOneTimeTokenRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentProfile` | [`GetOneTimeTokenRequestPaymentProfile`](../../doc/models/containers/get-one-time-token-request-payment-profile.md) | Required | This is a container for any-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

GetOneTimeTokenRequest getOneTimeTokenRequest = new GetOneTimeTokenRequest
{
    PaymentProfile = GetOneTimeTokenRequestPaymentProfile.FromGetOneTimeTokenPaymentProfile(
        new GetOneTimeTokenPaymentProfile
        {
            FirstName = "first_name2",
            LastName = "last_name0",
            MaskedCardNumber = "masked_card_number0",
            CardType = CardType.Routex,
            ExpirationMonth = 187.78,
            ExpirationYear = 164.44,
            CurrentVault = CreditCardVault.BraintreeBlue,
            VaultToken = "vault_token4",
            BillingAddress = "billing_address4",
            BillingCity = "billing_city0",
            BillingCountry = "billing_country6",
            BillingState = "billing_state6",
            BillingZip = "billing_zip0",
            PaymentType = "payment_type2",
            Disabled = false,
            SiteGatewaySettingId = 232,
            Id = "id2",
            CustomerId = "customer_id0",
            BillingAddress2 = "billing_address_24",
            CustomerVaultToken = "customer_vault_token0",
            GatewayHandle = "gateway_handle4",
        }
    ),
};
```

