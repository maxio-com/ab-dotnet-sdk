
# Update Wallet Request

## Structure

`UpdateWalletRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Wallet` | [`Wallet2`](../../doc/models/wallet-2.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateWalletRequest updateWalletRequest = new UpdateWalletRequest
{
    Wallet = new Wallet2
    {
        Name = "name6",
    },
};
```

