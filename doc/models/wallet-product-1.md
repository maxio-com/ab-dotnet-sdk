
# Wallet Product 1

## Structure

`WalletProduct1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Taxable` | `bool?` | Optional | - |
| `TaxCode` | `string` | Optional | - |
| `AccountingCode` | `string` | Optional | - |
| `ItemCategory` | [`ItemCategory?`](../../doc/models/item-category.md) | Optional | One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProduct1 walletProduct1 = new WalletProduct1
{
    Name = "name8",
    Description = "description8",
    Taxable = false,
    TaxCode = "tax_code6",
    AccountingCode = "accounting_code4",
    ItemCategory = ItemCategory.EnumBusinessSoftware,
};
```

