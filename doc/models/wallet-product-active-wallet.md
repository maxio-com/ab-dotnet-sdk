
# Wallet Product Active Wallet

One active wallet drawing on this Wallet Product.

## Structure

`WalletProductActiveWallet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The Advanced Billing id of the wallet. |
| `SubscriptionId` | `int?` | Optional | - |
| `CompanyName` | `string` | Optional | The owning customer's organization name, falling back to their full name, then to `"Customer #<id>"`. `"Customer"` (with no id) when the wallet's subscription has no customer at all. |
| `PurchaseMechanism` | `string` | Optional | See the same field on [Wallet Product Usage Template](../../doc/models/wallet-product-usage-template.md). The same caveats apply. |
| `PricePointName` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Active` | `bool?` | Optional | `false` when the wallet's Feature is archived. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProductActiveWallet walletProductActiveWallet = new WalletProductActiveWallet
{
    Id = 214,
    SubscriptionId = 68,
    CompanyName = "company_name8",
    PurchaseMechanism = "purchase_mechanism2",
    PricePointName = "price_point_name4",
};
```

