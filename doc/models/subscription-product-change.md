
# Subscription Product Change

Event data for both `subscription_product_change` and `subscription_product_change_scheduled`. The price point and `effective_at` fields are only populated for scheduled changes.

## Structure

`SubscriptionProductChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreviousProductId` | `int` | Required | - |
| `NewProductId` | `int` | Required | - |
| `PreviousProductPricePointId` | `int?` | Optional | - |
| `NewProductPricePointId` | `int?` | Optional | - |
| `EffectiveAt` | `DateTimeOffset?` | Optional | When the scheduled product change takes effect (the subscription's next renewal). Only sent for `subscription_product_change_scheduled`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

SubscriptionProductChange subscriptionProductChange = new SubscriptionProductChange
{
    PreviousProductId = 104,
    NewProductId = 10,
    PreviousProductPricePointId = 228,
    NewProductPricePointId = 222,
    EffectiveAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

