
# Component Cost Data

## Structure

`ComponentCostData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentCodeId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `Quantity` | `string` | Optional | - |
| `Amount` | `string` | Optional | - |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Tiers` | [`List<ComponentCostDataRateTier>`](../../doc/models/component-cost-data-rate-tier.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentCostData componentCostData = new ComponentCostData
{
    ComponentCodeId = 40,
    PricePointId = 210,
    ProductId = 18,
    Quantity = "quantity4",
    Amount = "amount0",
};
```

