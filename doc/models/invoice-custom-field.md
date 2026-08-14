
# Invoice Custom Field

## Structure

`InvoiceCustomField`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OwnerId` | `int?` | Optional | - |
| `OwnerType` | [`CustomFieldOwner?`](../../doc/models/custom-field-owner.md) | Optional | - |
| `Name` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `MValue` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `MetadatumId` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceCustomField invoiceCustomField = new InvoiceCustomField
{
    OwnerId = 14,
    OwnerType = CustomFieldOwner.Customer,
    Name = "name0",
    MValue = "value2",
    MetadatumId = 14,
};
```

