
# Create Prepaid Usage Component Price Point

## Structure

`CreatePrepaidUsageComponentPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Handle` | `string` | Optional | - |
| `PricingScheme` | [`PricingScheme`](../../doc/models/pricing-scheme.md) | Required | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Required | - |
| `OveragePricing` | [`OveragePricing`](../../doc/models/overage-pricing.md) | Required | - |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site.<br><br>**Default**: `true` |
| `RolloverPrepaidRemainder` | `bool?` | Optional | (only for prepaid usage components) Boolean which controls whether or not remaining units should be rolled over to the next period. |
| `RenewPrepaidAllocation` | `bool?` | Optional | (only for prepaid usage components) Boolean which controls whether or not the allocated quantity should be renewed at the beginning of each period. |
| `ExpirationInterval` | `double?` | Optional | (only for prepaid usage components where rollover_prepaid_remainder is true) The number of `expiration_interval_unit`s after which rollover amounts should expire. |
| `ExpirationIntervalUnit` | [`ExpirationIntervalUnit?`](../../doc/models/expiration-interval-unit.md) | Optional | (only for prepaid usage components where rollover_prepaid_remainder is true) A string representing the expiration interval unit for this component, either month or day. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreatePrepaidUsageComponentPricePoint createPrepaidUsageComponentPricePoint = new CreatePrepaidUsageComponentPricePoint
{
    Name = "name2",
    PricingScheme = PricingScheme.PerUnit,
    Prices = new List<Price>
    {
        new Price
        {
            StartingQuantity = PriceStartingQuantity.FromNumber(242),
            UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            EndingQuantity = PriceEndingQuantity.FromNumber(40),
        },
    },
    OveragePricing = new OveragePricing
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
        },
    },
    Handle = "handle8",
    UseSiteExchangeRate = true,
    RolloverPrepaidRemainder = false,
    RenewPrepaidAllocation = false,
    ExpirationInterval = 165.7,
};
```

