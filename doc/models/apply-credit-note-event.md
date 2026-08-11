
# Apply Credit Note Event

## Structure

`ApplyCreditNoteEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Timestamp` | `DateTimeOffset` | Required | - |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |
| `EventType` | [`InvoiceEventType`](../../doc/models/invoice-event-type.md) | Required | **Default**: `InvoiceEventType.apply_credit_note` |
| `EventData` | [`ApplyCreditNoteEventData`](../../doc/models/apply-credit-note-event-data.md) | Required | Example schema for an `apply_credit_note` event |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ApplyCreditNoteEvent applyCreditNoteEvent = new ApplyCreditNoteEvent
{
    Id = 86L,
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
    EventType = InvoiceEventType.ApplyCreditNote,
    EventData = new ApplyCreditNoteEventData
    {
        Uid = "uid6",
        CreditNoteNumber = "credit_note_number0",
        CreditNoteUid = "credit_note_uid0",
        OriginalAmount = "original_amount0",
        AppliedAmount = "applied_amount2",
        TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Memo = "memo0",
        Role = "role0",
        ConsolidatedInvoice = false,
        AppliedCreditNotes = new List<AppliedCreditNoteData>
        {
            new AppliedCreditNoteData
            {
                Uid = "uid4",
                Number = "number8",
            },
            new AppliedCreditNoteData
            {
                Uid = "uid4",
                Number = "number8",
            },
            new AppliedCreditNoteData
            {
                Uid = "uid4",
                Number = "number8",
            },
        },
    },
};
```

