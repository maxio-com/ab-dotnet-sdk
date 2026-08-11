
# Refund Invoice Event

## Structure

`RefundInvoiceEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Timestamp` | `DateTimeOffset` | Required | - |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |
| `EventType` | [`InvoiceEventType`](../../doc/models/invoice-event-type.md) | Required | **Default**: `InvoiceEventType.refund_invoice` |
| `EventData` | [`RefundInvoiceEventData`](../../doc/models/refund-invoice-event-data.md) | Required | Example schema for an `refund_invoice` event |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

RefundInvoiceEvent refundInvoiceEvent = new RefundInvoiceEvent
{
    Id = 132L,
    Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Invoice = new Invoice
    {
        Id = 166L,
        Uid = "uid6",
        SiteId = 92,
        CustomerId = 204,
        SubscriptionId = 20,
        IssueDate = DateTime.Parse("2024-01-01"),
        DueDate = DateTime.Parse("2024-01-01"),
        PaidDate = DateTime.Parse("2024-01-01"),
        PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
    },
    EventType = InvoiceEventType.RefundInvoice,
    EventData = new RefundInvoiceEventData
    {
        ApplyCredit = false,
        CreditNoteAttributes = new CreditNote
        {
            Uid = "uid2",
            SiteId = 72,
            CustomerId = 184,
            SubscriptionId = 0,
            Number = "number0",
        },
        PaymentId = 204,
        RefundAmount = "refund_amount8",
        RefundId = 248,
        TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ConsolidationLevel = InvoiceConsolidationLevel.Child,
        Memo = "memo0",
        OriginalAmount = "original_amount0",
    },
};
```

