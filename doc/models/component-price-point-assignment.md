
# Component Price Point Assignment

## Structure

`ComponentPricePointAssignment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | [`ComponentPricePointAssignmentComponentId`](../../doc/models/containers/component-price-point-assignment-component-id.md) | Optional | This is a container for one-of cases. |
| `PricePoint` | [`ComponentPricePointAssignmentPricePoint`](../../doc/models/containers/component-price-point-assignment-price-point.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

ComponentPricePointAssignment componentPricePointAssignment = new ComponentPricePointAssignment
{
    ComponentId = ComponentPricePointAssignmentComponentId.FromNumber(112),
    PricePoint = ComponentPricePointAssignmentPricePoint.FromString("String7"),
};
```

