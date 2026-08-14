
# Subscription Group Component Custom Price

Used in place of `price_point_id` to define a custom price point unique to the subscription. You still need to provide `component_id`.

## Structure

`SubscriptionGroupComponentCustomPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Optional | - |
| `OveragePricing` | [`List<ComponentCustomPrice>`](../../doc/models/component-custom-price.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

SubscriptionGroupComponentCustomPrice subscriptionGroupComponentCustomPrice = new SubscriptionGroupComponentCustomPrice
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
    },
    OveragePricing = new List<ComponentCustomPrice>
    {
        new ComponentCustomPrice
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
            Interval = 230,
            IntervalUnit = IntervalUnit.Day,
            ListPricePointId = 10,
        },
        new ComponentCustomPrice
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
            Interval = 230,
            IntervalUnit = IntervalUnit.Day,
            ListPricePointId = 10,
        },
        new ComponentCustomPrice
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
            Interval = 230,
            IntervalUnit = IntervalUnit.Day,
            ListPricePointId = 10,
        },
    },
};
```

