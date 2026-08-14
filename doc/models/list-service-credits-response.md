
# List Service Credits Response

## Structure

`ListServiceCreditsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceCredits` | [`List<ServiceCredit1>`](../../doc/models/service-credit-1.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListServiceCreditsResponse listServiceCreditsResponse = new ListServiceCreditsResponse
{
    ServiceCredits = new List<ServiceCredit1>
    {
        new ServiceCredit1
        {
            Id = 224,
            AmountInCents = 54L,
            EndingBalanceInCents = 94L,
            EntryType = ServiceCreditType.Credit,
            Memo = "memo2",
        },
        new ServiceCredit1
        {
            Id = 224,
            AmountInCents = 54L,
            EndingBalanceInCents = 94L,
            EntryType = ServiceCreditType.Credit,
            Memo = "memo2",
        },
        new ServiceCredit1
        {
            Id = 224,
            AmountInCents = 54L,
            EndingBalanceInCents = 94L,
            EntryType = ServiceCreditType.Credit,
            Memo = "memo2",
        },
    },
};
```

