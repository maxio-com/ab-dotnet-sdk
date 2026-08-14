
# Subscription State Filter

Allowed values for filtering by the current state of the subscription.

## Enumeration

`SubscriptionStateFilter`

## Fields

| Name |
|  --- |
| `Active` |
| `Canceled` |
| `Expired` |
| `ExpiredCards` |
| `EnumExpiredCardsLiveSubscriptions` |
| `EnumExpiredCardsAllSubscriptions` |
| `OnHold` |
| `AwaitingSignup` |
| `AwaitingSignupDate` |
| `PastDue` |
| `PendingCancellation` |
| `PendingRenewal` |
| `PrepaidDunning` |
| `Suspended` |
| `TrialEnded` |
| `Trialing` |
| `Unpaid` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionStateFilter subscriptionStateFilter = SubscriptionStateFilter.AwaitingSignup;
```

