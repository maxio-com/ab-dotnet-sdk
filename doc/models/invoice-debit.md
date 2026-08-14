
# Invoice Debit

## Structure

`InvoiceDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `DebitNoteNumber` | `string` | Optional | - |
| `DebitNoteUid` | `string` | Optional | - |
| `Role` | [`DebitNoteRole?`](../../doc/models/debit-note-role.md) | Optional | The role of the debit note. |
| `TransactionTime` | `DateTimeOffset?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `OriginalAmount` | `string` | Optional | - |
| `AppliedAmount` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

InvoiceDebit invoiceDebit = new InvoiceDebit
{
    Uid = "uid8",
    DebitNoteNumber = "debit_note_number8",
    DebitNoteUid = "debit_note_uid4",
    Role = DebitNoteRole.Chargeback,
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

