
# Credit Note Application

## Structure

`CreditNoteApplication`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `TransactionTime` | `DateTimeOffset?` | Optional | - |
| `InvoiceUid` | `string` | Optional | - |
| `Memo` | `string` | Optional | - |
| `AppliedAmount` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

CreditNoteApplication creditNoteApplication = new CreditNoteApplication
{
    Uid = "uid0",
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    InvoiceUid = "invoice_uid0",
    Memo = "memo4",
    AppliedAmount = "applied_amount8",
};
```

