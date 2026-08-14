
# Refund Invoice Request

## Structure

`RefundInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Refund` | [`RefundInvoiceRequestRefund`](../../doc/models/containers/refund-invoice-request-refund.md) | Required | This is a container for any-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

RefundInvoiceRequest refundInvoiceRequest = new RefundInvoiceRequest
{
    Refund = RefundInvoiceRequestRefund.FromRefundInvoice(
        new RefundInvoice
        {
            Amount = "amount8",
            Memo = "memo0",
            PaymentId = 0,
            External = false,
            ApplyCredit = false,
            VoidInvoice = false,
        }
    ),
};
```

