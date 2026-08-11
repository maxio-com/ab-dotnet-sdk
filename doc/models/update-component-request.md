
# Update Component Request

## Structure

`UpdateComponentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Component` | [`UpdateComponent`](../../doc/models/update-component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateComponentRequest updateComponentRequest = new UpdateComponentRequest
{
    Component = new UpdateComponent
    {
        Handle = "handle4",
        Name = "name8",
        Description = "description2",
        AccountingCode = "accounting_code4",
        Taxable = false,
        ItemCategory = ItemCategory.EnumBusinessSoftware,
    },
};
```

