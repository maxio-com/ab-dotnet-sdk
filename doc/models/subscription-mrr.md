
# Subscription MRR

## Structure

`SubscriptionMRR`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int` | Required | - |
| `MrrAmountInCents` | `long` | Required | - |
| `Breakouts` | [`SubscriptionMRRBreakout`](../../doc/models/subscription-mrr-breakout.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionMRR subscriptionMRR = new SubscriptionMRR
{
    SubscriptionId = 192,
    MrrAmountInCents = 210L,
    Breakouts = new SubscriptionMRRBreakout
    {
        PlanAmountInCents = 254L,
        UsageAmountInCents = 106L,
    },
};
```

