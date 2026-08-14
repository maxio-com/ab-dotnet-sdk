
# Multi Invoice Payment Response

## Structure

`MultiInvoicePaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payment` | [`MultiInvoicePayment`](../../doc/models/multi-invoice-payment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

MultiInvoicePaymentResponse multiInvoicePaymentResponse = new MultiInvoicePaymentResponse
{
    Payment = new MultiInvoicePayment
    {
        TransactionId = 224,
        TotalAmount = "total_amount2",
        CurrencyCode = "currency_code2",
        Applications = new List<InvoicePaymentApplication>
        {
            new InvoicePaymentApplication
            {
                InvoiceUid = "invoice_uid8",
                ApplicationUid = "application_uid8",
                AppliedAmount = "applied_amount0",
            },
            new InvoicePaymentApplication
            {
                InvoiceUid = "invoice_uid8",
                ApplicationUid = "application_uid8",
                AppliedAmount = "applied_amount0",
            },
            new InvoicePaymentApplication
            {
                InvoiceUid = "invoice_uid8",
                ApplicationUid = "application_uid8",
                AppliedAmount = "applied_amount0",
            },
        },
    },
};
```

