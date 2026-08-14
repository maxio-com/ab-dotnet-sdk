
# Create Multi Invoice Payment Request

## Structure

`CreateMultiInvoicePaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payment` | [`CreateMultiInvoicePayment`](../../doc/models/create-multi-invoice-payment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateMultiInvoicePaymentRequest createMultiInvoicePaymentRequest = new CreateMultiInvoicePaymentRequest
{
    Payment = new CreateMultiInvoicePayment
    {
        Amount = CreateMultiInvoicePaymentAmount.FromString("String9"),
        Applications = new List<CreateInvoicePaymentApplication>
        {
            new CreateInvoicePaymentApplication
            {
                InvoiceUid = "invoice_uid8",
                Amount = "amount0",
            },
        },
        Memo = "memo0",
        Details = "details6",
        Method = InvoicePaymentMethodType.Ach,
        ReceivedOn = "received_on8",
    },
};
```

