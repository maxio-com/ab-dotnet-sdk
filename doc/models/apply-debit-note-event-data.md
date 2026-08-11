
# Apply Debit Note Event Data

Example schema for an `apply_debit_note` event

## Structure

`ApplyDebitNoteEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DebitNoteNumber` | `string` | Required | A unique, identifying string that appears on the debit note and in places it is referenced. |
| `DebitNoteUid` | `string` | Required | Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters. |
| `OriginalAmount` | `string` | Required | The full, original amount of the debit note. |
| `AppliedAmount` | `string` | Required | The amount of the debit note applied to invoice. |
| `Memo` | `string` | Optional | The debit note memo. |
| `TransactionTime` | `DateTimeOffset?` | Optional | The time the debit note was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

ApplyDebitNoteEventData applyDebitNoteEventData = new ApplyDebitNoteEventData
{
    DebitNoteNumber = "debit_note_number8",
    DebitNoteUid = "debit_note_uid4",
    OriginalAmount = "original_amount2",
    AppliedAmount = "applied_amount0",
    Memo = "memo2",
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

