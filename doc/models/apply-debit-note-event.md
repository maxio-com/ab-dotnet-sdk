
# Apply Debit Note Event

## Structure

`ApplyDebitNoteEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Timestamp` | `DateTimeOffset` | Required | - |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |
| `EventType` | [`InvoiceEventType`](../../doc/models/invoice-event-type.md) | Required | **Default**: `InvoiceEventType.apply_debit_note` |
| `EventData` | [`ApplyDebitNoteEventData`](../../doc/models/apply-debit-note-event-data.md) | Required | Example schema for an `apply_debit_note` event |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

ApplyDebitNoteEvent applyDebitNoteEvent = new ApplyDebitNoteEvent
{
    Id = 180L,
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
    EventType = InvoiceEventType.ApplyDebitNote,
    EventData = new ApplyDebitNoteEventData
    {
        DebitNoteNumber = "debit_note_number6",
        DebitNoteUid = "debit_note_uid2",
        OriginalAmount = "original_amount0",
        AppliedAmount = "applied_amount2",
        Memo = "memo0",
        TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

