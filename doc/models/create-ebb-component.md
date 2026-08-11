
# Create EBB Component

## Structure

`CreateEBBComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EventBasedComponent` | [`EBBComponent`](../../doc/models/ebb-component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateEBBComponent createEBBComponent = new CreateEBBComponent
{
    EventBasedComponent = new EBBComponent
    {
        Name = "name8",
        UnitName = "unit_name0",
        PricingScheme = PricingScheme.Stairstep,
        EventBasedBillingMetricId = 68,
        Description = "description8",
        Handle = "handle4",
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
        PricePoints = new List<ComponentPricePointItem>
        {
            new ComponentPricePointItem
            {
                Name = "name2",
                Handle = "handle8",
                PricingScheme = PricingScheme.PerUnit,
                Interval = 92,
                IntervalUnit = IntervalUnit.Day,
            },
        },
    },
};
```

