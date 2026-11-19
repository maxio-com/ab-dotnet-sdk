
# Update Component Price Point

## Structure

`UpdateComponentPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site. |
| `TaxIncluded` | `bool?` | Optional | Whether or not the price point includes tax |
| `Interval` | `int?` | Optional | The numerical interval. e.g., an interval of ‘30’ coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled. |
| `Prices` | [`List<UpdatePrice>`](../../doc/models/update-price.md) | Optional | - |
| `SecondaryPricing` | [`UpdateSecondaryPricing`](../../doc/models/update-secondary-pricing.md) | Optional | Hybrid Pricing only. Changes the secondary pricing model of an existing hybrid price point. Send `pricing_scheme` (or the top-level `secondary_pricing_scheme`) every time you send this block; a block without a scheme returns `422`. Brackets sent without an `id` are added to the existing ones rather than replacing them, so to change a bracket set, update existing brackets by `id` and remove the ones you no longer want with `_destroy: true`. See [Hybrid Pricing](page:introduction/basic-concepts/hybrid-pricing). |
| `SecondaryPricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | Hybrid Pricing only. Alternative to `secondary_pricing.pricing_scheme`; when both are sent, `secondary_pricing.pricing_scheme` is used. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateComponentPricePoint updateComponentPricePoint = new UpdateComponentPricePoint
{
    Name = "name4",
    Handle = "handle0",
    PricingScheme = PricingScheme.Stairstep,
    UseSiteExchangeRate = false,
    TaxIncluded = false,
};
```

