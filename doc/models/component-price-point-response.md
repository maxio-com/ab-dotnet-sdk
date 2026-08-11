
# Component Price Point Response

## Structure

`ComponentPricePointResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`ComponentPricePoint`](../../doc/models/component-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentPricePointResponse componentPricePointResponse = new ComponentPricePointResponse
{
    PricePoint = new ComponentPricePoint
    {
        Id = 248,
        Type = PricePointType.Default,
        MDefault = false,
        Name = "name0",
        PricingScheme = PricingScheme.PerUnit,
    },
};
```

