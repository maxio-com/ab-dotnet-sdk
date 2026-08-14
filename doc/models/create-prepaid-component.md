
# Create Prepaid Component

## Structure

`CreatePrepaidComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrepaidUsageComponent` | [`PrepaidUsageComponent`](../../doc/models/prepaid-usage-component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreatePrepaidComponent createPrepaidComponent = new CreatePrepaidComponent
{
    PrepaidUsageComponent = new PrepaidUsageComponent
    {
        Name = "name2",
        UnitName = "unit_name4",
        PricingScheme = PricingScheme.PerUnit,
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
        Description = "description2",
        Handle = "handle8",
        Taxable = false,
        Prices = new List<Price>
        {
            new Price
            {
                StartingQuantity = PriceStartingQuantity.FromNumber(242),
                UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                EndingQuantity = PriceEndingQuantity.FromNumber(40),
            },
        },
        UpgradeCharge = CreditType.Full,
    },
};
```

