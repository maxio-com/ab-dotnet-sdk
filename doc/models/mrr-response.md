
# MRR Response

## Structure

`MRRResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mrr` | [`MRR`](../../doc/models/mrr.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

MRRResponse mRRResponse = new MRRResponse
{
    Mrr = new MRR
    {
        AmountInCents = 198L,
        AmountFormatted = "amount_formatted6",
        Currency = "currency4",
        CurrencySymbol = "currency_symbol2",
        Breakouts = new Breakouts
        {
            PlanAmountInCents = 254L,
            PlanAmountFormatted = "plan_amount_formatted0",
            UsageAmountInCents = 106L,
            UsageAmountFormatted = "usage_amount_formatted8",
        },
    },
};
```

