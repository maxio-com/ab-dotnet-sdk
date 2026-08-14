
# Tokenized Payment Profile

## Structure

`TokenizedPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `VaultToken` | `string` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |
| `CustomerVaultToken` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

TokenizedPaymentProfile tokenizedPaymentProfile = new TokenizedPaymentProfile
{
    Id = 116,
    VaultToken = "vault_token0",
    GatewayHandle = "gateway_handle0",
    CustomerVaultToken = "customer_vault_token6",
};
```

