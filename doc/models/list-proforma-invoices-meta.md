
# List Proforma Invoices Meta

## Structure

`ListProformaInvoicesMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalCount` | `int?` | Optional | - |
| `CurrentPage` | `int?` | Optional | - |
| `TotalPages` | `int?` | Optional | - |
| `StatusCode` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListProformaInvoicesMeta listProformaInvoicesMeta = new ListProformaInvoicesMeta
{
    TotalCount = 50,
    CurrentPage = 26,
    TotalPages = 38,
    StatusCode = 68,
};
```

