
# Segment Price

## Structure

`SegmentPrice`

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

SegmentPrice segmentPrice = new SegmentPrice
{
    Id = 194,
    ComponentId = 48,
    StartingQuantity = 144,
    EndingQuantity = 118,
    UnitPrice = "unit_price0",
};
```

