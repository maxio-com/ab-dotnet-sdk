
# Offer Item

## Structure

`OfferItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `StartingQuantity` | `string` | Optional | - |
| `Editable` | `bool?` | Optional | - |
| `ComponentUnitPrice` | `string` | Optional | - |
| `ComponentName` | `string` | Optional | - |
| `PricePointName` | `string` | Optional | - |
| `CurrencyPrices` | [`List<CurrencyPrice>`](../../doc/models/currency-price.md) | Optional | - |
| `Interval` | `int?` | Optional | The numerical interval. e.g., an interval of '30' coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

OfferItem offerItem = new OfferItem
{
    ComponentId = 234,
    PricePointId = 254,
    StartingQuantity = "starting_quantity6",
    Editable = false,
    ComponentUnitPrice = "component_unit_price2",
};
```

