
# Wallet Product Response

A Wallet Product is a Component created with no product family, so it returns the full Component field set under a `wallet_product` root instead of `component`.

## Structure

`WalletProductResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletProduct` | [`Component`](../../doc/models/component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProductResponse walletProductResponse = new WalletProductResponse
{
    WalletProduct = new Component
    {
        Id = 224,
        Name = "name0",
        Handle = "handle6",
        PricingScheme = PricingScheme.PerUnit,
        UnitName = "unit_name2",
        ItemCategory = ItemCategory.EnumBusinessSoftware,
    },
};
```

