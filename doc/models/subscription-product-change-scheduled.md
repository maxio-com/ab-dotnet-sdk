
# Subscription Product Change Scheduled

## Structure

`SubscriptionProductChangeScheduled`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreviousProductId` | `int` | Required | - |
| `NewProductId` | `int` | Required | - |
| `PreviousProductPricePointId` | `int?` | Optional | - |
| `NewProductPricePointId` | `int?` | Optional | - |
| `EffectiveAt` | `DateTimeOffset?` | Optional | When the scheduled product change takes effect (the subscription's next renewal). |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

SubscriptionProductChangeScheduled subscriptionProductChangeScheduled = new SubscriptionProductChangeScheduled
{
    PreviousProductId = 26,
    NewProductId = 88,
    PreviousProductPricePointId = 150,
    NewProductPricePointId = 144,
    EffectiveAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

