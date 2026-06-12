
# Refund Invoice Request Refund

## Class Name

`RefundInvoiceRequestRefund`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`RefundInvoice`](../../../doc/models/refund-invoice.md) | RefundInvoiceRequestRefund.FromRefundInvoice(RefundInvoice refundInvoice) |
| [`RefundConsolidatedInvoice`](../../../doc/models/refund-consolidated-invoice.md) | RefundInvoiceRequestRefund.FromRefundConsolidatedInvoice(RefundConsolidatedInvoice refundConsolidatedInvoice) |

## RefundInvoice

### Initialization Code

#### Example

```csharp
RefundInvoiceRequestRefund value = RefundInvoiceRequestRefund.FromRefundInvoice(
    new RefundInvoice
    {
        Amount = "amount8",
        Memo = "memo0",
        PaymentId = 0,
    }
);
```

## RefundConsolidatedInvoice

### Initialization Code

#### Example

```csharp
RefundInvoiceRequestRefund value = RefundInvoiceRequestRefund.FromRefundConsolidatedInvoice(
    new RefundConsolidatedInvoice
    {
        Memo = "memo0",
        PaymentId = 46,
        SegmentUids = RefundConsolidatedInvoiceSegmentUids.FromListOfString(
            new List<string>
            {
                "String0",
                "String1",
            }
        ),
    }
);
```

