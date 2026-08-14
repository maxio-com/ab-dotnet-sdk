
# Create Multi Invoice Payment

## Structure

`CreateMultiInvoicePayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Memo` | `string` | Optional | A description to be attached to the payment. |
| `Details` | `string` | Optional | Additional information related to the payment method (eg. Check #). |
| `Method` | [`InvoicePaymentMethodType?`](../../doc/models/invoice-payment-method-type.md) | Optional | The type of payment method used. Defaults to other. |
| `Amount` | [`CreateMultiInvoicePaymentAmount`](../../doc/models/containers/create-multi-invoice-payment-amount.md) | Required | This is a container for one-of cases. |
| `ReceivedOn` | `string` | Optional | Date reflecting when the payment was received from a customer. Must be in the past. |
| `Applications` | [`List<CreateInvoicePaymentApplication>`](../../doc/models/create-invoice-payment-application.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateMultiInvoicePayment createMultiInvoicePayment = new CreateMultiInvoicePayment
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
};
```

