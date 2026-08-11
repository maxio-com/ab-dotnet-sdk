
# Create Subscription Request

## Structure

`CreateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscription` | [`CreateSubscription`](../../doc/models/create-subscription.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateSubscriptionRequest createSubscriptionRequest = new CreateSubscriptionRequest
{
    Subscription = new CreateSubscription
    {
        ProductHandle = "product_handle6",
        ProductId = 206,
        ProductPricePointHandle = "product_price_point_handle2",
        ProductPricePointId = 130,
        CustomPrice = new SubscriptionCustomPrice
        {
            PriceInCents = SubscriptionCustomPricePriceInCents.FromString("String3"),
            Interval = SubscriptionCustomPriceInterval.FromString("String3"),
            IntervalUnit = IntervalUnit.Day,
            Name = "name4",
            Handle = "handle0",
            TrialPriceInCents = SubscriptionCustomPriceTrialPriceInCents.FromString("String3"),
            TrialInterval = SubscriptionCustomPriceTrialInterval.FromString("String5"),
            TrialIntervalUnit = IntervalUnit.Day,
        },
        DeferSignup = false,
        Metafields = new Dictionary<string, string>
        {
            ["custom_field_name_1"] = "custom_field_value_1",
            ["custom_field_name_2"] = "custom_field_value_2",
        },
        DunningCommunicationDelayEnabled = false,
        DunningCommunicationDelayTimeZone = "\"Eastern Time (US & Canada)\"",
    },
};
```

