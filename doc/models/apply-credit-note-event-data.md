
# Apply Credit Note Event Data

Example schema for an `apply_credit_note` event

## Structure

`ApplyCreditNoteEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Required | Unique identifier for the credit note application. It is generated automatically by Chargify and has the prefix "cdt_" followed by alphanumeric characters. |
| `CreditNoteNumber` | `string` | Required | A unique, identifying string that appears on the credit note and in places it is referenced. |
| `CreditNoteUid` | `string` | Required | Unique identifier for the credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters. |
| `OriginalAmount` | `string` | Required | The full, original amount of the credit note. |
| `AppliedAmount` | `string` | Required | The amount of the credit note applied to invoice. |
| `TransactionTime` | `DateTimeOffset?` | Optional | The time the credit note was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |
| `Memo` | `string` | Optional | The credit note memo. |
| `Role` | `string` | Optional | The role of the credit note (e.g. 'general') |
| `ConsolidatedInvoice` | `bool?` | Optional | Shows whether it was applied to consolidated invoice or not. |
| `AppliedCreditNotes` | [`List<AppliedCreditNoteData>`](../../doc/models/applied-credit-note-data.md) | Optional | List of credit notes applied to children invoices (if consolidated invoice) |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ApplyCreditNoteEventData applyCreditNoteEventData = new ApplyCreditNoteEventData
{
    Uid = "uid0",
    CreditNoteNumber = "credit_note_number6",
    CreditNoteUid = "credit_note_uid4",
    OriginalAmount = "original_amount4",
    AppliedAmount = "applied_amount8",
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Memo = "memo4",
    Role = "role4",
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
};
```

