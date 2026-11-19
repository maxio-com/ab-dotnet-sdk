
# Wallets List Response

## Structure

`WalletsListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Wallets` | [`List<Wallet>`](../../doc/models/wallet.md) | Required | - |
| `Meta` | [`ListPublicKeysMeta`](../../doc/models/list-public-keys-meta.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

WalletsListResponse walletsListResponse = new WalletsListResponse
{
    Wallets = new List<Wallet>
    {
        new Wallet
        {
            Id = 80,
            OwnerType = OwnerType.Subscription,
            OwnerId = 156,
            Name = "name4",
            WalletProductId = 72,
            Unit = "tokens",
            Balance = "150.0",
            PostedBalance = "150.0",
            DepletionPolicy = "hard_stop",
        },
    },
    Meta = new ListPublicKeysMeta
    {
        TotalCount = 150,
        CurrentPage = 126,
        TotalPages = 138,
        PerPage = 152,
    },
};
```

