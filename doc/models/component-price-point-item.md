
# Component Price Point Item

## Structure

`ComponentPricePointItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Interval` | `int?` | Optional | The numerical interval. e.g., an interval of ‘30’ coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentPricePointItem componentPricePointItem = new ComponentPricePointItem
{
    Name = "name8",
    Handle = "handle4",
    PricingScheme = PricingScheme.Stairstep,
    Interval = 138,
    IntervalUnit = IntervalUnit.Day,
};
```

