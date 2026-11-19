
# Create Wallet Request

## Structure

`CreateWalletRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Wallet` | [`Wallet1`](../../doc/models/wallet-1.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateWalletRequest createWalletRequest = new CreateWalletRequest
{
    Wallet = new Wallet1
    {
        SubscriptionId = 94,
        WalletProductId = Wallet1WalletProductId.FromNumber(154),
        Name = "name6",
        DepletionPolicy = "depletion_policy4",
        HardStopOverflow = WalletHardStopOverflow.Discard,
        MeterId = 146,
        ConversionRate = Wallet1ConversionRate.FromString("String9"),
        InitialBalance = Wallet1InitialBalance.FromString("String1"),
    },
};
```

