
# Create Invoice Payment Application

## Structure

`CreateInvoicePaymentApplication`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InvoiceUid` | `string` | Required | Unique identifier for the invoice. It has the prefix "inv_" followed by alphanumeric characters. |
| `Amount` | `string` | Required | Dollar amount of the invoice payment (eg. "10.50" => $10.50). |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateInvoicePaymentApplication createInvoicePaymentApplication = new CreateInvoicePaymentApplication
{
    InvoiceUid = "invoice_uid6",
    Amount = "amount8",
};
```

