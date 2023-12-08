
# Apply Debit Note Event Data

Example schema for an `apply_debit_note` event

## Structure

`ApplyDebitNoteEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DebitNoteNumber` | `string` | Optional | A unique, identifying string that appears on the debit note and in places it is referenced. |
| `DebitNoteUid` | `string` | Optional | Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters. |
| `OriginalAmount` | `string` | Optional | The full, original amount of the debit note. |
| `AppliedAmount` | `string` | Optional | The amount of the debit note applied to invoice. |

## Example (as JSON)

```json
{
  "debit_note_number": "debit_note_number0",
  "debit_note_uid": "debit_note_uid6",
  "original_amount": "original_amount4",
  "applied_amount": "applied_amount8"
}
```

