
# Wallet Product

## Structure

`WalletProduct`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `UnitName` | `string` | Required | The name of the unit the Wallet Product's usage is measured in, for example `tokens`. |
| `Handle` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Taxable` | `bool?` | Optional | - |
| `TaxCode` | `string` | Optional | - |
| `AccountingCode` | `string` | Optional | - |
| `ItemCategory` | [`ItemCategory?`](../../doc/models/item-category.md) | Optional | One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other |
| `PricePoint` | [`WalletProductPricePointAttributes`](../../doc/models/wallet-product-price-point-attributes.md) | Optional | Creates one price point for the Wallet Product in the same call. Ignored if `price_points` is also sent. |
| `PricePoints` | [`List<WalletProductPricePointAttributes>`](../../doc/models/wallet-product-price-point-attributes.md) | Optional | Creates several price points for the Wallet Product in the same call, winning over `price_point` if both are sent. The first price point created becomes the Wallet Product's default. The whole call is one transaction: if any price point in the array fails validation, nothing is created, including the Wallet Product itself. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProduct walletProduct = new WalletProduct
{
    Name = "name4",
    UnitName = "unit_name6",
    Handle = "handle0",
    Description = "description4",
    Taxable = false,
    TaxCode = "tax_code2",
    AccountingCode = "accounting_code0",
    ItemCategory = ItemCategory.EnumBusinessSoftware,
};
```

