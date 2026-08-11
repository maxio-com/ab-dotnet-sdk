
# MRR

## Structure

`MRR`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountInCents` | `long?` | Optional | - |
| `AmountFormatted` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `CurrencySymbol` | `string` | Optional | - |
| `Breakouts` | [`Breakouts`](../../doc/models/breakouts.md) | Optional | - |
| `AtTime` | `DateTimeOffset?` | Optional | ISO8601 timestamp |

## Example

```csharp
using AdvancedBilling.Standard.Models;

MRR mRR = new MRR
{
    AmountInCents = 122L,
    AmountFormatted = "amount_formatted4",
    Currency = "currency2",
    CurrencySymbol = "currency_symbol0",
    Breakouts = new Breakouts
    {
        PlanAmountInCents = 254L,
        PlanAmountFormatted = "plan_amount_formatted0",
        UsageAmountInCents = 106L,
        UsageAmountFormatted = "usage_amount_formatted8",
    },
};
```

