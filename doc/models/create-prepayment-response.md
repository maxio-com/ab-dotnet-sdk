
# Create Prepayment Response

## Structure

`CreatePrepaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayment` | [`CreatedPrepayment`](../../doc/models/created-prepayment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

CreatePrepaymentResponse createPrepaymentResponse = new CreatePrepaymentResponse
{
    Prepayment = new CreatedPrepayment
    {
        Id = 38L,
        SubscriptionId = 148,
        AmountInCents = 124L,
        Memo = "memo2",
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

