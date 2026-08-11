
# Component Allocation Change

## Structure

`ComponentAllocationChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreviousAllocation` | `int` | Required | - |
| `NewAllocation` | `int` | Required | - |
| `ComponentId` | `int` | Required | - |
| `ComponentHandle` | `string` | Required | - |
| `Memo` | `string` | Required | - |
| `AllocationId` | `int` | Required | - |
| `AllocatedQuantity` | [`ComponentAllocationChangeAllocatedQuantity`](../../doc/models/containers/component-allocation-change-allocated-quantity.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

ComponentAllocationChange componentAllocationChange = new ComponentAllocationChange
{
    PreviousAllocation = 78,
    NewAllocation = 118,
    ComponentId = 72,
    ComponentHandle = "component_handle8",
    Memo = "memo2",
    AllocationId = 174,
    AllocatedQuantity = ComponentAllocationChangeAllocatedQuantity.FromNumber(88),
};
```

