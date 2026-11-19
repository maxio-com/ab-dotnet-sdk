
# Wallet Product Usage Template

One wallet template billing through this Wallet Product, joined to the Feature and plan/component that assigns it, when there is one.

## Structure

`WalletProductUsageTemplate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanName` | `string` | Optional | The name of the product or component the Feature is assigned to. `null` when the wallet template has no assigning Feature. |
| `WalletTemplateName` | `string` | Optional | The label set in `wallet_behavior.name` on the Feature, or the standalone wallet's own `name`. |
| `UnitName` | `string` | Optional | - |
| `PurchaseMechanism` | `string` | Optional | A best-effort label for how this wallet is expected to be replenished. Currently reports `"Overage"` when the wallet template allows a negative balance, and `null` otherwise; there's no persisted field yet distinguishing, for example, an intended "Auto top-up" from "Purchase more" setup. Treat this as informational, not a stable enum. |
| `PricePointName` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Active` | `bool?` | Optional | `false` when the assigning Feature is archived. |
| `FeatureTemplateId` | `int?` | Optional | - |
| `FeatureTemplateName` | `string` | Optional | - |
| `PricePointOverride` | `bool?` | Optional | `true` when this wallet template is priced at a price point other than the Wallet Product's default. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProductUsageTemplate walletProductUsageTemplate = new WalletProductUsageTemplate
{
    PlanName = "plan_name0",
    WalletTemplateName = "wallet_template_name8",
    UnitName = "unit_name0",
    PurchaseMechanism = "purchase_mechanism8",
    PricePointName = "price_point_name8",
};
```

