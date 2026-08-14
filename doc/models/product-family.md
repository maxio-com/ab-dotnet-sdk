
# Product Family

## Structure

`ProductFamily`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `AccountingCode` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Surcharging` | `bool?` | Optional | Whether surcharging applies to this product family. Only included on sites where surcharging is enabled. |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `ArchivedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this product family was archived. `null` if the product family is not archived. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProductFamily productFamily = new ProductFamily
{
    Id = 134,
    Name = "name4",
    Handle = "handle0",
    AccountingCode = "accounting_code0",
    Description = "description4",
};
```

