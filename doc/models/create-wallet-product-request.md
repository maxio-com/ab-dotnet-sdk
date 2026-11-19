
# Create Wallet Product Request

Does not accept `product_family_id`: a Wallet Product never belongs to a product family. The underlying endpoint accepts the param, but only to reject it; sending one returns `422` ("Product family cannot be set on a wallet product") rather than silently ignoring it.

## Structure

`CreateWalletProductRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletProduct` | [`WalletProduct`](../../doc/models/wallet-product.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateWalletProductRequest createWalletProductRequest = new CreateWalletProductRequest
{
    WalletProduct = new WalletProduct
    {
        Name = "name0",
        UnitName = "unit_name2",
        Handle = "handle6",
        Description = "description0",
        Taxable = false,
        TaxCode = "tax_code8",
        AccountingCode = "accounting_code6",
        ItemCategory = ItemCategory.EnumBusinessSoftware,
    },
};
```

