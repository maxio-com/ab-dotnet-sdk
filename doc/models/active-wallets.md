
# Active Wallets

## Structure

`ActiveWallets`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Total` | `int` | Required | Total count of active wallets drawing on this product. |
| `Sample` | [`List<WalletProductActiveWallet>`](../../doc/models/wallet-product-active-wallet.md) | Required | Up to 50 of the most recently created active wallets, newest first. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ActiveWallets activeWallets = new ActiveWallets
{
    Total = 120,
    Sample = new List<WalletProductActiveWallet>
    {
        new WalletProductActiveWallet
        {
            Id = 180,
            SubscriptionId = 34,
            CompanyName = "company_name4",
            PurchaseMechanism = "purchase_mechanism8",
            PricePointName = "price_point_name8",
        },
    },
};
```

