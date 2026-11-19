
# Secondary Pricing

Hybrid Pricing only. The secondary pricing model that takes over once usage passes the primary model's included threshold. Applies to Quantity-Based and Metered Components on Sites with Hybrid Pricing enabled; ignored otherwise. Its `prices` brackets start at `1`, not at the primary model's highest `ending_quantity`. See [Hybrid Pricing](page:introduction/basic-concepts/hybrid-pricing).

## Structure

`SecondaryPricing`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | Required, unless you send the top-level `secondary_pricing_scheme` instead (Create and Update Component Price Point only). A block with neither returns `422` (`Secondary pricing scheme must be defined`). |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

SecondaryPricing secondaryPricing = new SecondaryPricing
{
    PricingScheme = PricingScheme.Stairstep,
    Prices = new List<Price>
    {
        new Price
        {
            StartingQuantity = PriceStartingQuantity.FromNumber(242),
            UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            EndingQuantity = PriceEndingQuantity.FromNumber(40),
        },
        new Price
        {
            StartingQuantity = PriceStartingQuantity.FromNumber(242),
            UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            EndingQuantity = PriceEndingQuantity.FromNumber(40),
        },
        new Price
        {
            StartingQuantity = PriceStartingQuantity.FromNumber(242),
            UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            EndingQuantity = PriceEndingQuantity.FromNumber(40),
        },
    },
};
```

