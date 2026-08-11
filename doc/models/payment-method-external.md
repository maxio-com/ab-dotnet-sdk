
# Payment Method External

## Structure

`PaymentMethodExternal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Details` | `string` | Required | - |
| `Kind` | `string` | Required | - |
| `Memo` | `string` | Required | - |
| `Type` | [`InvoiceEventPaymentMethod`](../../doc/models/invoice-event-payment-method.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentMethodExternal paymentMethodExternal = new PaymentMethodExternal
{
    Details = "details0",
    Kind = "kind8",
    Memo = "memo4",
    Type = InvoiceEventPaymentMethod.External,
};
```

