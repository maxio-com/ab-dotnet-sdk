
# Payment Method Credit Card

## Structure

`PaymentMethodCreditCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardBrand` | `string` | Required | - |
| `CardExpiration` | `string` | Optional | - |
| `LastFour` | `string` | Optional | - |
| `MaskedCardNumber` | `string` | Required | - |
| `Type` | [`InvoiceEventPaymentMethod`](../../doc/models/invoice-event-payment-method.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentMethodCreditCard paymentMethodCreditCard = new PaymentMethodCreditCard
{
    CardBrand = "card_brand4",
    MaskedCardNumber = "masked_card_number0",
    Type = InvoiceEventPaymentMethod.CreditCard,
    CardExpiration = "card_expiration2",
    LastFour = "last_four6",
};
```

