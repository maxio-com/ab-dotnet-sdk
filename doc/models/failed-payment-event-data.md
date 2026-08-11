
# Failed Payment Event Data

Example schema for an `failed_payment` event

## Structure

`FailedPaymentEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountInCents` | `int` | Required | The monetary value of the payment, expressed in cents. |
| `AppliedAmount` | `int` | Required | The monetary value of the payment, expressed in dollars. |
| `Memo` | `string` | Optional | The memo passed when the payment was created. |
| `PaymentMethod` | [`InvoicePaymentMethodType`](../../doc/models/invoice-payment-method-type.md) | Required | - |
| `TransactionId` | `int` | Required | The transaction ID of the failed payment. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

FailedPaymentEventData failedPaymentEventData = new FailedPaymentEventData
{
    AmountInCents = 34,
    AppliedAmount = 196,
    PaymentMethod = InvoicePaymentMethodType.Ach,
    TransactionId = 76,
    Memo = "memo0",
};
```

