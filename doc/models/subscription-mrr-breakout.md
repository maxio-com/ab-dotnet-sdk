
# Subscription MRR Breakout

## Structure

`SubscriptionMRRBreakout`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanAmountInCents` | `long` | Required | - |
| `UsageAmountInCents` | `long` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionMRRBreakout subscriptionMRRBreakout = new SubscriptionMRRBreakout
{
    PlanAmountInCents = 248L,
    UsageAmountInCents = 100L,
};
```

