
# Payment Method Paypal

## Structure

`PaymentMethodPaypal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Required | - |
| `Type` | [`InvoiceEventPaymentMethod`](../../doc/models/invoice-event-payment-method.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentMethodPaypal paymentMethodPaypal = new PaymentMethodPaypal
{
    Email = "email8",
    Type = InvoiceEventPaymentMethod.PaypalAccount,
};
```

