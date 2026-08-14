
# Subscription MRR Response

## Structure

`SubscriptionMRRResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionsMrr` | [`List<SubscriptionMRR>`](../../doc/models/subscription-mrr.md) | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionMRRResponse subscriptionMRRResponse = new SubscriptionMRRResponse
{
    SubscriptionsMrr = new List<SubscriptionMRR>
    {
        new SubscriptionMRR
        {
            SubscriptionId = 0,
            MrrAmountInCents = 0L,
            Breakouts = new SubscriptionMRRBreakout
            {
                PlanAmountInCents = 0L,
                UsageAmountInCents = 0L,
            },
        },
    },
};
```

