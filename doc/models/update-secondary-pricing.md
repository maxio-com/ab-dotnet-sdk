
# Update Secondary Pricing

Hybrid Pricing only. Changes the secondary pricing model of an existing hybrid price point. Send `pricing_scheme` (or the top-level `secondary_pricing_scheme`) every time you send this block; a block without a scheme returns `422`. Brackets sent without an `id` are added to the existing ones rather than replacing them, so to change a bracket set, update existing brackets by `id` and remove the ones you no longer want with `_destroy: true`. See [Hybrid Pricing](page:introduction/basic-concepts/hybrid-pricing).

## Structure

`UpdateSecondaryPricing`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<UpdatePrice>`](../../doc/models/update-price.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

UpdateSecondaryPricing updateSecondaryPricing = new UpdateSecondaryPricing
{
    PricingScheme = PricingScheme.PerUnit,
    Prices = new List<UpdatePrice>
    {
        new UpdatePrice
        {
            Id = 18,
            EndingQuantity = UpdatePriceEndingQuantity.FromNumber(40),
            UnitPrice = UpdatePriceUnitPrice.FromPrecision(23.26),
            Destroy = false,
            StartingQuantity = UpdatePriceStartingQuantity.FromNumber(242),
        },
    },
};
```

