
# Record Payment Response

## Structure

`RecordPaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaidInvoices` | [`List<PaidInvoice>`](../../doc/models/paid-invoice.md) | Optional | - |
| `Prepayment` | [`InvoicePrePayment`](../../doc/models/invoice-pre-payment.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

RecordPaymentResponse recordPaymentResponse = new RecordPaymentResponse
{
    PaidInvoices = new List<PaidInvoice>
    {
        new PaidInvoice
        {
            InvoiceId = "invoice_id8",
            Status = InvoiceStatus.Draft,
            DueAmount = "due_amount0",
            PaidAmount = "paid_amount0",
        },
    },
    Prepayment = new InvoicePrePayment
    {
        SubscriptionId = 148,
        AmountInCents = 124L,
        EndingBalanceInCents = 164L,
    },
};
```

