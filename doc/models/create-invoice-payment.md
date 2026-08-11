
# Create Invoice Payment

## Structure

`CreateInvoicePayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`CreateInvoicePaymentAmount`](../../doc/models/containers/create-invoice-payment-amount.md) | Optional | This is a container for one-of cases. |
| `Memo` | `string` | Optional | A description to be attached to the payment. Applicable only to `external` payments. |
| `Method` | [`InvoicePaymentMethodType?`](../../doc/models/invoice-payment-method-type.md) | Optional | The type of payment method used. Defaults to other. |
| `Details` | `string` | Optional | Additional information related to the payment method (eg. Check #). Applicable only to `external` payments. |
| `PaymentProfileId` | `int?` | Optional | The ID of the payment profile to be used for the payment. |
| `ReceivedOn` | `DateTime?` | Optional | Date reflecting when the payment was received from a customer. Must be in the past. Applicable only to<br>`external` payments. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateInvoicePayment createInvoicePayment = new CreateInvoicePayment
{
    Amount = CreateInvoicePaymentAmount.FromString("String7"),
    Memo = "memo8",
    Method = InvoicePaymentMethodType.Ach,
    Details = "details4",
    PaymentProfileId = 30,
};
```

