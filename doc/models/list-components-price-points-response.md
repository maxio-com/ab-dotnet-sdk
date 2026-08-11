
# List Components Price Points Response

## Structure

`ListComponentsPricePointsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<ComponentPricePoint>`](../../doc/models/component-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListComponentsPricePointsResponse listComponentsPricePointsResponse = new ListComponentsPricePointsResponse
{
    PricePoints = new List<ComponentPricePoint>
    {
        new ComponentPricePoint
        {
            Id = 40,
            Type = PricePointType.Default,
            MDefault = false,
            Name = "name2",
            PricingScheme = PricingScheme.PerUnit,
        },
    },
};
```

