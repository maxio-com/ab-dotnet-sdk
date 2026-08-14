
# Invoice Credit

## Structure

`InvoiceCredit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `CreditNoteNumber` | `string` | Optional | - |
| `CreditNoteUid` | `string` | Optional | - |
| `TransactionTime` | `DateTimeOffset?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `OriginalAmount` | `string` | Optional | - |
| `AppliedAmount` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

InvoiceCredit invoiceCredit = new InvoiceCredit
{
    Uid = "uid8",
    CreditNoteNumber = "credit_note_number2",
    CreditNoteUid = "credit_note_uid2",
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Memo = "memo2",
};
```

