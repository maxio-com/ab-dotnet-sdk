
# Prepaid Usage

## Structure

`PrepaidUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreviousUnitBalance` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PreviousOverageUnitBalance` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `NewUnitBalance` | [`PrepaidUsageNewUnitBalance`](../../doc/models/containers/prepaid-usage-new-unit-balance.md) | Required | This is a container for one-of cases. |
| `NewOverageUnitBalance` | [`PrepaidUsageNewOverageUnitBalance`](../../doc/models/containers/prepaid-usage-new-overage-unit-balance.md) | Required | This is a container for one-of cases. |
| `UsageQuantity` | `int` | Required | - |
| `OverageUsageQuantity` | `int` | Required | - |
| `ComponentId` | `int` | Required | - |
| `ComponentHandle` | `string` | Required | - |
| `Memo` | `string` | Required | - |
| `AllocationDetails` | [`List<PrepaidUsageAllocationDetail>`](../../doc/models/prepaid-usage-allocation-detail.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

PrepaidUsage prepaidUsage = new PrepaidUsage
{
    PreviousUnitBalance = "previous_unit_balance4",
    PreviousOverageUnitBalance = "previous_overage_unit_balance0",
    NewUnitBalance = PrepaidUsageNewUnitBalance.FromNumber(206),
    NewOverageUnitBalance = PrepaidUsageNewOverageUnitBalance.FromNumber(78),
    UsageQuantity = 246,
    OverageUsageQuantity = 138,
    ComponentId = 208,
    ComponentHandle = "component_handle0",
    Memo = "memo4",
    AllocationDetails = new List<PrepaidUsageAllocationDetail>
    {
        new PrepaidUsageAllocationDetail
        {
            AllocationId = 18,
            ChargeId = 84,
            UsageQuantity = 10,
        },
    },
};
```

