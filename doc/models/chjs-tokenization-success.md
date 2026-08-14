
# Chjs Tokenization Success

## Structure

`ChjsTokenizationSuccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentProfile` | [`TokenizedPaymentProfile`](../../doc/models/tokenized-payment-profile.md) | Required | - |
| `GatewayCustomerId` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ChjsTokenizationSuccess chjsTokenizationSuccess = new ChjsTokenizationSuccess
{
    PaymentProfile = new TokenizedPaymentProfile
    {
        Id = 44,
        VaultToken = "vault_token6",
        GatewayHandle = "gateway_handle4",
        CustomerVaultToken = "customer_vault_token2",
    },
    GatewayCustomerId = 228,
};
```

