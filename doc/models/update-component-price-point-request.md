
# Update Component Price Point Request

## Structure

`UpdateComponentPricePointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`UpdateComponentPricePoint`](../../doc/models/update-component-price-point.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateComponentPricePointRequest updateComponentPricePointRequest = new UpdateComponentPricePointRequest
{
    PricePoint = new UpdateComponentPricePoint
    {
        Name = "name0",
        Handle = "handle6",
        PricingScheme = PricingScheme.PerUnit,
        UseSiteExchangeRate = false,
        TaxIncluded = false,
    },
};
```

