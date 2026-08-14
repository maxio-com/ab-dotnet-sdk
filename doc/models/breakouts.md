
# Breakouts

## Structure

`Breakouts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanAmountInCents` | `long?` | Optional | - |
| `PlanAmountFormatted` | `string` | Optional | - |
| `UsageAmountInCents` | `long?` | Optional | - |
| `UsageAmountFormatted` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Breakouts breakouts = new Breakouts
{
    PlanAmountInCents = 254L,
    PlanAmountFormatted = "plan_amount_formatted0",
    UsageAmountInCents = 106L,
    UsageAmountFormatted = "usage_amount_formatted8",
};
```

