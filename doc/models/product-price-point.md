
# Product Price Point

## Structure

`ProductPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | The product price point name |
| `Handle` | `string` | Optional | The product price point API handle |
| `PriceInCents` | `long?` | Optional | The product price point price, in integer cents |
| `Interval` | `int?` | Optional | The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this product price point would renew every 30 days |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this product price point, either month or day |
| `TrialPriceInCents` | `long?` | Optional | The product price point trial price, in integer cents |
| `TrialInterval` | `int?` | Optional | The numerical trial interval. i.e. an interval of ‘30’ coupled with an trial_interval_unit of day would mean this product price point would renew every 30 days |
| `TrialIntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the trial interval unit for this product price point, either month or day |
| `TrialType` | `string` | Optional | - |
| `IntroductoryOffer` | `bool?` | Optional | reserved for future use |
| `InitialChargeInCents` | `long?` | Optional | The product price point initial charge, in integer cents |
| `InitialChargeAfterTrial` | `bool?` | Optional | - |
| `ExpirationInterval` | `int?` | Optional | The numerical expiration interval. i.e. an expiration_interval of ‘30’ coupled with an expiration_interval_unit of day would mean this product price point would expire every 30 days |
| `ExpirationIntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the expiration interval unit for this product price point, either month or day |
| `ProductId` | `int?` | Optional | The product id this price point belongs to |
| `ArchivedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this price point was archived |
| `CreatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this price point was created |
| `UpdatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this price point was last updated |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether or not to use the site's exchange rate or define your own pricing when your site has multiple currencies defined. |
| `Type` | [`PricePointType?`](../../doc/models/price-point-type.md) | Optional | The type of price point |
| `TaxIncluded` | `bool?` | Optional | Whether or not the price point includes tax |
| `SubscriptionId` | `int?` | Optional | The subscription id this price point belongs to |

## Example (as JSON)

```json
{
  "id": 196,
  "name": "name6",
  "handle": "handle2",
  "price_in_cents": 248,
  "interval": 8
}
```

