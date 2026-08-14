
# Component Cost Data Rate Tier

## Structure

`ComponentCostDataRateTier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartingQuantity` | `int?` | Optional | - |
| `EndingQuantity` | `int?` | Optional | - |
| `Quantity` | `string` | Optional | - |
| `UnitPrice` | `string` | Optional | - |
| `Amount` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentCostDataRateTier componentCostDataRateTier = new ComponentCostDataRateTier
{
    StartingQuantity = 204,
    EndingQuantity = 178,
    Quantity = "quantity4",
    UnitPrice = "unit_price6",
    Amount = "amount0",
};
```

