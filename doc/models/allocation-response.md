
# Allocation Response

## Structure

`AllocationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Allocation` | [`Allocation`](../../doc/models/allocation.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

AllocationResponse allocationResponse = new AllocationResponse
{
    Allocation = new Allocation
    {
        AllocationId = 238,
        ComponentId = 8,
        ComponentHandle = "component_handle8",
        SubscriptionId = 8,
        Quantity = AllocationQuantity.FromNumber(32),
    },
};
```

