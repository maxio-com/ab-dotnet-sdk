
# Wallet Product Usage Response

## Structure

`WalletProductUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletTemplates` | [`List<WalletProductUsageTemplate>`](../../doc/models/wallet-product-usage-template.md) | Required | Wallet templates billing through this product at its default price point. |
| `PricePointOverrides` | [`List<WalletProductUsageTemplate>`](../../doc/models/wallet-product-usage-template.md) | Required | Wallet templates billing through this product at a price point other than the default. |
| `ActiveWallets` | [`ActiveWallets`](../../doc/models/active-wallets.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

WalletProductUsageResponse walletProductUsageResponse = new WalletProductUsageResponse
{
    WalletTemplates = new List<WalletProductUsageTemplate>
    {
        new WalletProductUsageTemplate
        {
            PlanName = "plan_name4",
            WalletTemplateName = "wallet_template_name2",
            UnitName = "unit_name4",
            PurchaseMechanism = "purchase_mechanism2",
            PricePointName = "price_point_name4",
        },
    },
    PricePointOverrides = new List<WalletProductUsageTemplate>
    {
        new WalletProductUsageTemplate
        {
            PlanName = "plan_name0",
            WalletTemplateName = "wallet_template_name2",
            UnitName = "unit_name0",
            PurchaseMechanism = "purchase_mechanism8",
            PricePointName = "price_point_name8",
        },
    },
    ActiveWallets = new ActiveWallets
    {
        Total = 164,
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
    },
};
```

