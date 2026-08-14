
# Invoice Payment Type

The type of payment to be applied to an Invoice. Defaults to external.

## Enumeration

`InvoicePaymentType`

## Fields

| Name |
|  --- |
| `External` |
| `Prepayment` |
| `ServiceCredit` |
| `Payment` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoicePaymentType invoicePaymentType = InvoicePaymentType.External;
```

