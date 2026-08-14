
# Customer Custom Fields Change

## Structure

`CustomerCustomFieldsChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Before` | [`List<InvoiceCustomField>`](../../doc/models/invoice-custom-field.md) | Required | - |
| `After` | [`List<InvoiceCustomField>`](../../doc/models/invoice-custom-field.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CustomerCustomFieldsChange customerCustomFieldsChange = new CustomerCustomFieldsChange
{
    Before = new List<InvoiceCustomField>
    {
        new InvoiceCustomField
        {
            OwnerId = 26,
            OwnerType = CustomFieldOwner.Customer,
            Name = "name0",
            MValue = "value2",
            MetadatumId = 26,
        },
    },
    After = new List<InvoiceCustomField>
    {
        new InvoiceCustomField
        {
            OwnerId = 130,
            OwnerType = CustomFieldOwner.Customer,
            Name = "name2",
            MValue = "value4",
            MetadatumId = 130,
        },
    },
};
```

