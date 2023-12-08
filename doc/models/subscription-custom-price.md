
# Subscription Custom Price

(Optional) Used in place of `product_price_point_id` to define a custom price point unique to the subscription

## Structure

`SubscriptionCustomPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | (Optional) |
| `Handle` | `string` | Optional | (Optional) |
| `PriceInCents` | [`SubscriptionCustomPricePriceInCents`](../../doc/models/containers/subscription-custom-price-price-in-cents.md) | Required | This is a container for one-of cases. |
| `Interval` | [`SubscriptionCustomPriceInterval`](../../doc/models/containers/subscription-custom-price-interval.md) | Required | This is a container for one-of cases. |
| `IntervalUnit` | [`IntervalUnit`](../../doc/models/interval-unit.md) | Required | Required if using `custom_price` attribute. |
| `TrialPriceInCents` | [`SubscriptionCustomPriceTrialPriceInCents`](../../doc/models/containers/subscription-custom-price-trial-price-in-cents.md) | Optional | This is a container for one-of cases. |
| `TrialInterval` | [`SubscriptionCustomPriceTrialInterval`](../../doc/models/containers/subscription-custom-price-trial-interval.md) | Optional | This is a container for one-of cases. |
| `TrialIntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | (Optional) |
| `InitialChargeInCents` | [`SubscriptionCustomPriceInitialChargeInCents`](../../doc/models/containers/subscription-custom-price-initial-charge-in-cents.md) | Optional | This is a container for one-of cases. |
| `InitialChargeAfterTrial` | `bool?` | Optional | (Optional) |
| `ExpirationInterval` | [`SubscriptionCustomPriceExpirationInterval`](../../doc/models/containers/subscription-custom-price-expiration-interval.md) | Optional | This is a container for one-of cases. |
| `ExpirationIntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | (Optional) |
| `TaxIncluded` | `bool?` | Optional | (Optional) |

## Example (as JSON)

```json
{
  "name": "name4",
  "handle": "handle0",
  "price_in_cents": "String3",
  "interval": "String3",
  "interval_unit": "day",
  "trial_price_in_cents": "String3",
  "trial_interval": "String5",
  "trial_interval_unit": "day"
}
```

