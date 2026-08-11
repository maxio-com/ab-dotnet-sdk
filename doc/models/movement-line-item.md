
# Movement Line Item

## Structure

`MovementLineItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductId` | `int?` | Optional | - |
| `ComponentId` | `int?` | Optional | For Product (or "baseline") line items, this field will have a value of `0`. |
| `PricePointId` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Mrr` | `int?` | Optional | - |
| `MrrMovements` | [`List<MRRMovement>`](../../doc/models/mrr-movement.md) | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `PrevQuantity` | `int?` | Optional | - |
| `Recurring` | `bool?` | Optional | When `true`, the line item's MRR value will contribute to the `plan` breakout. When `false`, the line item contributes to the `usage` breakout. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

MovementLineItem movementLineItem = new MovementLineItem
{
    ProductId = 146,
    ComponentId = 58,
    PricePointId = 82,
    Name = "name8",
    Mrr = 92,
};
```

