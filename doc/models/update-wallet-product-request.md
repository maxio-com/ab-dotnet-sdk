
# Update Wallet Product Request

Only `name`, `description`, `taxable`, `tax_code`, `accounting_code`, and `item_category` are mutable. `unit_name`, `handle`, `price_point`, and `price_points` are not accepted here: the request still returns `200`, but those fields are silently ignored and nothing about them changes. `handle` stays fixed because it's the Wallet Product's only stable identifier on a surface with no product family in the path; `unit_name` stays fixed because a wallet's behavior snapshots it into the wallet's own `unit` field and never re-derives it.

## Structure

`UpdateWalletProductRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletProduct` | [`WalletProduct1`](../../doc/models/wallet-product-1.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateWalletProductRequest updateWalletProductRequest = new UpdateWalletProductRequest
{
    WalletProduct = new WalletProduct1
    {
        Name = "name0",
        Description = "description0",
        Taxable = false,
        TaxCode = "tax_code8",
        AccountingCode = "accounting_code6",
        ItemCategory = ItemCategory.EnumBusinessSoftware,
    },
};
```

