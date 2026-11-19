
# Wallet Product Price Point Summary

A summary of the Wallet Product's default price point, for rendering a catalog listing without a separate price points call.

## Structure

`WalletProductPricePointSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ArchivedCount` | `int?` | Optional | Number of archived price points on this Wallet Product. |
| `PricingScheme` | `string` | Optional | The default price point's pricing scheme. `null` if the Wallet Product has no default price point. |
| `TierCount` | `int?` | Optional | Number of price brackets on the default price point. A `per_unit` scheme always stores exactly one synthesized bracket, so this is `1` for `per_unit`, not `0`. |
| `EntryPrice` | `string` | Optional | The unit price of the default price point's first bracket, as a decimal string. `null` if there are no brackets. |
| `FinalPrice` | `string` | Optional | The unit price of the default price point's last bracket, as a decimal string. `null` if there are no brackets. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProductPricePointSummary walletProductPricePointSummary = new WalletProductPricePointSummary
{
    ArchivedCount = 244,
    PricingScheme = "pricing_scheme8",
    TierCount = 30,
    EntryPrice = "entry_price8",
    FinalPrice = "final_price4",
};
```

