
# Create Quantity Based Component

## Structure

`CreateQuantityBasedComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `QuantityBasedComponent` | [`QuantityBasedComponent`](../../doc/models/quantity-based-component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateQuantityBasedComponent createQuantityBasedComponent = new CreateQuantityBasedComponent
{
    QuantityBasedComponent = new QuantityBasedComponent
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
        },
        UpgradeCharge = CreditType.Prorated,
    },
};
```

