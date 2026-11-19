
# Create Wallet Transaction Request

## Structure

`CreateWalletTransactionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletTransaction` | [`WalletTransaction1`](../../doc/models/wallet-transaction-1.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateWalletTransactionRequest createWalletTransactionRequest = new CreateWalletTransactionRequest
{
    WalletTransaction = new WalletTransaction1
    {
        Kind = Kind1.Grant,
        Amount = WalletTransaction1Amount.FromString("String5"),
        Memo = "memo6",
        ExpiresAt = "expires_at6",
    },
};
```

