
# Payment Method Bank Account

## Structure

`PaymentMethodBankAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaskedAccountNumber` | `string` | Required | - |
| `MaskedRoutingNumber` | `string` | Required | - |
| `Type` | [`InvoiceEventPaymentMethod`](../../doc/models/invoice-event-payment-method.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentMethodBankAccount paymentMethodBankAccount = new PaymentMethodBankAccount
{
    MaskedAccountNumber = "masked_account_number4",
    MaskedRoutingNumber = "masked_routing_number4",
    Type = InvoiceEventPaymentMethod.BankAccount,
};
```

