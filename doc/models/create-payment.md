
# Create Payment

## Structure

`CreatePayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `string` | Required | - |
| `Memo` | `string` | Required | - |
| `PaymentDetails` | `string` | Required | - |
| `PaymentMethod` | [`InvoicePaymentMethodType`](../../doc/models/invoice-payment-method-type.md) | Required | The type of payment method used. Defaults to other. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreatePayment createPayment = new CreatePayment
{
    Amount = "amount6",
    Memo = "memo8",
    PaymentDetails = "payment_details4",
    PaymentMethod = InvoicePaymentMethodType.CreditCard,
};
```

