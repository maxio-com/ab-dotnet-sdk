
# Multi Invoice Payment

## Structure

`MultiInvoicePayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionId` | `int?` | Optional | The numeric ID of the transaction. |
| `TotalAmount` | `string` | Optional | Dollar amount of the sum of the paid invoices. |
| `CurrencyCode` | `string` | Optional | The ISO 4217 currency code (3 character string) representing the currency of invoice transaction. |
| `Applications` | [`List<InvoicePaymentApplication>`](../../doc/models/invoice-payment-application.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

MultiInvoicePayment multiInvoicePayment = new MultiInvoicePayment
{
    TransactionId = 246,
    TotalAmount = "total_amount0",
    CurrencyCode = "currency_code0",
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
    },
};
```

