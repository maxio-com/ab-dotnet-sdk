
# Void Remainder Event Data

Example schema for an `void_remainder` event

## Structure

`VoidRemainderEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreditNoteAttributes` | [`CreditNote`](../../doc/models/credit-note.md) | Required | - |
| `Memo` | `string` | Required | The memo provided during invoice remainder voiding. |
| `AppliedAmount` | `string` | Required | The amount of the void. |
| `TransactionTime` | `DateTimeOffset` | Required | The time the refund was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

VoidRemainderEventData voidRemainderEventData = new VoidRemainderEventData
{
    CreditNoteAttributes = new CreditNote
    {
        Uid = "uid2",
        SiteId = 72,
        CustomerId = 184,
        SubscriptionId = 0,
        Number = "number0",
    },
    Memo = "memo6",
    AppliedAmount = "applied_amount6",
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

