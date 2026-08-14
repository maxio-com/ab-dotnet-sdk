
# Create Allocation Request

## Structure

`CreateAllocationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Allocation` | [`CreateAllocation`](../../doc/models/create-allocation.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateAllocationRequest createAllocationRequest = new CreateAllocationRequest
{
    Allocation = new CreateAllocation
    {
        Quantity = 228.94,
        DecimalQuantity = "decimal_quantity6",
        PreviousQuantity = 254.04,
        DecimalPreviousQuantity = "decimal_previous_quantity8",
        ComponentId = 8,
        Memo = "memo2",
    },
};
```

