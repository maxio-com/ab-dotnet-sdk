
# Paid Invoice

## Structure

`PaidInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InvoiceId` | `string` | Optional | The uid of the paid invoice |
| `Status` | [`InvoiceStatus?`](../../doc/models/invoice-status.md) | Optional | The current status of the invoice. See [Invoice Statuses](https://docs.maxio.com/billing/invoicing/overview/understand-how-invoices-are-generated#invoice-statuses) for more. |
| `DueAmount` | `string` | Optional | The remaining due amount on the invoice |
| `PaidAmount` | `string` | Optional | The total amount paid on this invoice (including any prior payments) |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaidInvoice paidInvoice = new PaidInvoice
{
    InvoiceId = "invoice_id2",
    Status = InvoiceStatus.Canceled,
    DueAmount = "due_amount4",
    PaidAmount = "paid_amount6",
};
```

