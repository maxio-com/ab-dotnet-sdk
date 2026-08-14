
# Record Payment Request

## Structure

`RecordPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payment` | [`CreatePayment`](../../doc/models/create-payment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

RecordPaymentRequest recordPaymentRequest = new RecordPaymentRequest
{
    Payment = new CreatePayment
    {
        Amount = "amount8",
        Memo = "memo0",
        PaymentDetails = "payment_details6",
        PaymentMethod = InvoicePaymentMethodType.Cash,
    },
};
```

