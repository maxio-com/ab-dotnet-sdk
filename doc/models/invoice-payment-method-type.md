
# Invoice Payment Method Type

The type of payment method used. Defaults to other.

## Enumeration

`InvoicePaymentMethodType`

## Fields

| Name |
|  --- |
| `CreditCard` |
| `Check` |
| `Cash` |
| `MoneyOrder` |
| `Ach` |
| `Other` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoicePaymentMethodType invoicePaymentMethodType = InvoicePaymentMethodType.Cash;
```

