
# Subscription Response

## Structure

`SubscriptionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscription` | [`Subscription`](../../doc/models/subscription.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionResponse subscriptionResponse = new SubscriptionResponse
{
    Subscription = new Subscription
    {
        Id = 8,
        State = SubscriptionState.Paused,
        BalanceInCents = 124L,
        TotalRevenueInCents = 48L,
        ProductPriceInCents = 238L,
    },
};
```

