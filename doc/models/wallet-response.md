
# Wallet Response

## Structure

`WalletResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Wallet` | [`Wallet`](../../doc/models/wallet.md) | Required | A balance, denominated in the unit of a Wallet Product, owned by a subscription. Grants and recurring funding schedules are embedded so a single read shows the full balance breakdown. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletResponse walletResponse = new WalletResponse
{
    Wallet = new Wallet
    {
        Id = 240,
        OwnerType = OwnerType.Subscription,
        OwnerId = 60,
        Name = "name6",
        WalletProductId = 232,
        Unit = "tokens",
        Balance = "150.0",
        PostedBalance = "150.0",
        DepletionPolicy = "hard_stop",
    },
};
```

