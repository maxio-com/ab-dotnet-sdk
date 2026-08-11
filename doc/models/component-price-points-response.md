
# Component Price Points Response

## Structure

`ComponentPricePointsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<ComponentPricePoint>`](../../doc/models/component-price-point.md) | Optional | - |
| `Meta` | [`ListPublicKeysMeta`](../../doc/models/list-public-keys-meta.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ComponentPricePointsResponse componentPricePointsResponse = new ComponentPricePointsResponse
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
        new ComponentPricePoint
        {
            Id = 40,
            Type = PricePointType.Default,
            MDefault = false,
            Name = "name2",
            PricingScheme = PricingScheme.PerUnit,
        },
        new ComponentPricePoint
        {
            Id = 40,
            Type = PricePointType.Default,
            MDefault = false,
            Name = "name2",
            PricingScheme = PricingScheme.PerUnit,
        },
    },
    Meta = new ListPublicKeysMeta
    {
        TotalCount = 150,
        CurrentPage = 126,
        TotalPages = 138,
        PerPage = 152,
    },
};
```

