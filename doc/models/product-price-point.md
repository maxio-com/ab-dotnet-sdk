
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
| `Interval` | `int?` | Optional | The numerical interval. e.g., an interval of ‘30’ coupled with an interval_unit of day would mean this product price point would renew every 30 days. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this product price point, either month or day |
| `TrialPriceInCents` | `long?` | Optional | The product price point trial price, in integer cents |
| `TrialInterval` | `int?` | Optional | The numerical trial interval. e.g., an interval of ‘30’ coupled with a trial_interval_unit of day would mean this product price point trial would last 30 days. |
| `TrialIntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the trial interval unit for this product price point, either month or day |
| `TrialType` | [`TrialType?`](../../doc/models/trial-type.md) | Optional | Indicates how a trial is handled when the trial period ends and there is no credit card on file. For `no_obligation`, the subscription transitions to a Trial Ended state. Maxio will not send any emails or statements. For `payment_expected`, the subscription transitions to a Past Due state. Maxio will send normal dunning emails and statements according to your other settings. |
| `IntroductoryOffer` | `bool?` | Optional | reserved for future use |
| `InitialChargeInCents` | `long?` | Optional | The product price point initial charge, in integer cents |
| `InitialChargeAfterTrial` | `bool?` | Optional | - |
| `ExpirationInterval` | `int?` | Optional | The numerical expiration interval. e.g., an expiration_interval of ‘30’ coupled with an expiration_interval_unit of day would mean this product price point would expire after 30 days. |
| `ExpirationIntervalUnit` | [`ExpirationIntervalUnit?`](../../doc/models/expiration-interval-unit.md) | Optional | A string representing the expiration interval unit for this product price point, either month, day or never |
| `ProductId` | `int?` | Optional | The product id this price point belongs to |
| `ArchivedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this price point was archived |
| `CreatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this price point was created |
| `UpdatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this price point was last updated |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether or not to use the site's exchange rate or define your own pricing when your site has multiple currencies defined. |
| `Type` | [`PricePointType?`](../../doc/models/price-point-type.md) | Optional | The type of price point |
| `TaxIncluded` | `bool?` | Optional | Whether or not the price point includes tax |
| `SubscriptionId` | `int?` | Optional | The subscription id this price point belongs to |
| `CurrencyPrices` | [`List<CurrencyPrice>`](../../doc/models/currency-price.md) | Optional | An array of currency pricing data is available when multiple currencies are defined for the site. It varies based on the use_site_exchange_rate setting for the price point. This parameter is present only in the response of read endpoints, after including the appropriate query parameter. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProductPricePoint productPricePoint = new ProductPricePoint
{
    Id = 10,
    Name = "name0",
    Handle = "handle6",
    PriceInCents = 178L,
    Interval = 194,
};
```

