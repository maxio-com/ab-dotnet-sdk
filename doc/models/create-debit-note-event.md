
# Create Debit Note Event

## Structure

`CreateDebitNoteEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Timestamp` | `DateTimeOffset` | Required | - |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |
| `EventType` | [`InvoiceEventType`](../../doc/models/invoice-event-type.md) | Required | **Default**: `InvoiceEventType.create_debit_note` |
| `EventData` | [`DebitNote`](../../doc/models/debit-note.md) | Required | Example schema for an `create_debit_note` event |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

CreateDebitNoteEvent createDebitNoteEvent = new CreateDebitNoteEvent
{
    Id = 176L,
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
    EventType = InvoiceEventType.CreateDebitNote,
    EventData = new DebitNote
    {
        Uid = "uid6",
        SiteId = 132,
        CustomerId = 244,
        SubscriptionId = 60,
        Number = 64,
    },
};
```

