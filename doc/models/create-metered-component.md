
# Create Metered Component

## Structure

`CreateMeteredComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MeteredComponent` | [`MeteredComponent`](../../doc/models/metered-component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateMeteredComponent createMeteredComponent = new CreateMeteredComponent
{
    MeteredComponent = new MeteredComponent
    {
        Name = "name0",
        UnitName = "unit_name2",
        PricingScheme = PricingScheme.Stairstep,
        Description = "description0",
        Handle = "handle6",
        Taxable = false,
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
        SecondaryPricing = new SecondaryPricing
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
        },
    },
};
```

