
# Invoice Payer Change

## Structure

`InvoicePayerChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Organization` | `string` | Optional | - |
| `Email` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoicePayerChange invoicePayerChange = new InvoicePayerChange
{
    FirstName = "first_name4",
    LastName = "last_name2",
    Organization = "organization2",
    Email = "email2",
};
```

