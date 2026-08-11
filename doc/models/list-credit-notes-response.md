
# List Credit Notes Response

## Structure

`ListCreditNotesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreditNotes` | [`List<CreditNote>`](../../doc/models/credit-note.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListCreditNotesResponse listCreditNotesResponse = new ListCreditNotesResponse
{
    CreditNotes = new List<CreditNote>
    {
        new CreditNote
        {
            Uid = "uid2",
            SiteId = 112,
            CustomerId = 224,
            SubscriptionId = 40,
            Number = "number0",
        },
    },
};
```

