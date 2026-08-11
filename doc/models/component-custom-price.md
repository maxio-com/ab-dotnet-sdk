
# Component Custom Price

Create or update custom pricing unique to the subscription. Used in place of `price_point_id`.

## Structure

`ComponentCustomPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TaxIncluded` | `bool?` | Optional | Whether or not the price point includes tax |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | Omit for On/Off components. |
| `Interval` | `int?` | Optional | The numerical interval. e.g., an interval of ‘30’ coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled. |
| `ListPricePointId` | `int?` | Optional | (Optional) Id of the price point to use for list price calculations when<br>overriding the customer price. |
| `UseDefaultListPrice` | `bool?` | Optional | When true, list price calculations will continue to use the default price point even when a `custom_price` is supplied. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Required | On/off components only need one price bracket starting at 1. |
| `RenewPrepaidAllocation` | `bool?` | Optional | Applicable only to prepaid usage components. Controls whether the allocated quantity renews each period. |
| `RolloverPrepaidRemainder` | `bool?` | Optional | Applicable only to prepaid usage components. Controls whether remaining units roll over to the next period. |
| `ExpirationInterval` | `int?` | Optional | Applicable only when rollover is enabled. Number of `expiration_interval_unit`s after which rollover amounts expire. |
| `ExpirationIntervalUnit` | [`ExpirationIntervalUnit?`](../../doc/models/expiration-interval-unit.md) | Optional | Applicable only when rollover is enabled. Interval unit for rollover expiration (month or day). |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

ComponentCustomPrice componentCustomPrice = new ComponentCustomPrice
{
    Prices = new List<Price>
    {
        new Price
        {
            StartingQuantity = PriceStartingQuantity.FromNumber(242),
            UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            EndingQuantity = PriceEndingQuantity.FromNumber(40),
        },
    },
    TaxIncluded = false,
    PricingScheme = PricingScheme.Stairstep,
    Interval = 58,
    IntervalUnit = IntervalUnit.Day,
    ListPricePointId = 182,
};
```

