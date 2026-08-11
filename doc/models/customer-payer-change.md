
# Customer Payer Change

## Structure

`CustomerPayerChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Before` | [`InvoicePayerChange`](../../doc/models/invoice-payer-change.md) | Required | - |
| `After` | [`InvoicePayerChange`](../../doc/models/invoice-payer-change.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CustomerPayerChange customerPayerChange = new CustomerPayerChange
{
    Before = new InvoicePayerChange
    {
        FirstName = "first_name0",
        LastName = "last_name8",
        Organization = "organization4",
        Email = "email6",
    },
    After = new InvoicePayerChange
    {
        FirstName = "first_name2",
        LastName = "last_name0",
        Organization = "organization4",
        Email = "email4",
    },
};
```

