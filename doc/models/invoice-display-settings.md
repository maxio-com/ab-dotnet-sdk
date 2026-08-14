
# Invoice Display Settings

## Structure

`InvoiceDisplaySettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HideZeroSubtotalLines` | `bool?` | Optional | - |
| `IncludeDiscountsOnLines` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceDisplaySettings invoiceDisplaySettings = new InvoiceDisplaySettings
{
    HideZeroSubtotalLines = false,
    IncludeDiscountsOnLines = false,
};
```

