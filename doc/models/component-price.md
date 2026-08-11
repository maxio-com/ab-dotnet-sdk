
# Component Price

## Structure

`ComponentPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `StartingQuantity` | `int?` | Optional | - |
| `EndingQuantity` | `int?` | Optional | - |
| `UnitPrice` | `string` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `FormattedUnitPrice` | `string` | Optional | - |
| `SegmentId` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentPrice componentPrice = new ComponentPrice
{
    Id = 18,
    ComponentId = 128,
    StartingQuantity = 64,
    EndingQuantity = 218,
    UnitPrice = "unit_price4",
};
```

