
# Update Component

## Structure

`UpdateComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Handle` | `string` | Optional | - |
| `Name` | `string` | Optional | The name of the Component, suitable for display on statements. e.g., Text Messages. |
| `Description` | `string` | Optional | The description of the component. |
| `AccountingCode` | `string` | Optional | - |
| `Taxable` | `bool?` | Optional | Boolean flag describing whether a component is taxable or not. |
| `TaxCode` | `string` | Optional | A string representing the tax code related to the component type. This is especially important when using AvaTax to tax based on locale. This attribute has a max length of 25 characters. |
| `ItemCategory` | [`ItemCategory?`](../../doc/models/item-category.md) | Optional | One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other |
| `DisplayOnHostedPage` | `bool?` | Optional | - |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `UnspscCode` | `string` | Optional | (Optional) Custom UNSPSC commodity code for Level 3/CEDP payment data. When set, this value is sent as the commodity code on invoice line items for this component instead of the default derived from item_category. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateComponent updateComponent = new UpdateComponent
{
    Handle = "handle4",
    Name = "name8",
    Description = "description8",
    AccountingCode = "accounting_code4",
    Taxable = false,
    ItemCategory = ItemCategory.EnumBusinessSoftware,
};
```

