
# Create Invoice Payment Request

## Structure

`CreateInvoicePaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payment` | [`CreateInvoicePayment`](../../doc/models/create-invoice-payment.md) | Required | - |
| `Type` | [`InvoicePaymentType?`](../../doc/models/invoice-payment-type.md) | Optional | The type of payment to be applied to an Invoice. Defaults to external. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateInvoicePaymentRequest createInvoicePaymentRequest = new CreateInvoicePaymentRequest
{
    Payment = new CreateInvoicePayment
    {
        Amount = CreateInvoicePaymentAmount.FromString("String9"),
        Memo = "memo0",
        Method = InvoicePaymentMethodType.Ach,
        Details = "details6",
        PaymentProfileId = 42,
    },
    Type = InvoicePaymentType.External,
};
```

