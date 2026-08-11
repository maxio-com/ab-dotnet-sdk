
# Component Price Point Assignment

## Structure

`ComponentPricePointAssignment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | `int?` | Optional | - |
| `PricePoint` | [`ComponentPricePointAssignmentPricePoint`](../../doc/models/containers/component-price-point-assignment-price-point.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

ComponentPricePointAssignment componentPricePointAssignment = new ComponentPricePointAssignment
{
    ComponentId = 190,
    PricePoint = ComponentPricePointAssignmentPricePoint.FromString("String7"),
};
```

