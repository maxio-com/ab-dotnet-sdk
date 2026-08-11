
# List Invoice Events Response

## Structure

`ListInvoiceEventsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Events` | [`List<InvoiceEvent>`](../../doc/models/containers/invoice-event.md) | Optional | - |
| `Page` | `int?` | Optional | - |
| `PerPage` | `int?` | Optional | - |
| `TotalPages` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;
using System.Globalization;

ListInvoiceEventsResponse listInvoiceEventsResponse = new ListInvoiceEventsResponse
{
    Events = new List<InvoiceEvent>
    {
        InvoiceEvent.FromApplyCreditNoteEvent(
            new ApplyCreditNoteEvent
            {
                Id = 214L,
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
            }
        ),
        InvoiceEvent.FromApplyCreditNoteEvent(
            new ApplyCreditNoteEvent
            {
                Id = 214L,
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
            }
        ),
        InvoiceEvent.FromApplyCreditNoteEvent(
            new ApplyCreditNoteEvent
            {
                Id = 214L,
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
            }
        ),
    },
    Page = 28,
    PerPage = 196,
    TotalPages = 94,
};
```

