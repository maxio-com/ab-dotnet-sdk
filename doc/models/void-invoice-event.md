
# Void Invoice Event

## Structure

`VoidInvoiceEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Timestamp` | `DateTimeOffset` | Required | - |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |
| `EventType` | [`InvoiceEventType`](../../doc/models/invoice-event-type.md) | Required | **Default**: `InvoiceEventType.void_invoice` |
| `EventData` | [`VoidInvoiceEventData`](../../doc/models/void-invoice-event-data.md) | Required | Example schema for an `void_invoice` event |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

VoidInvoiceEvent voidInvoiceEvent = new VoidInvoiceEvent
{
    Id = 236L,
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
    EventType = InvoiceEventType.VoidInvoice,
    EventData = new VoidInvoiceEventData
    {
        CreditNoteAttributes = new CreditNote
        {
            Uid = "uid2",
            SiteId = 72,
            CustomerId = 184,
            SubscriptionId = 0,
            Number = "number0",
        },
        Memo = "memo0",
        AppliedAmount = "applied_amount2",
        TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        IsAdvanceInvoice = false,
        Reason = "reason2",
    },
};
```

