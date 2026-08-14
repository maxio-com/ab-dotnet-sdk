
# Metered Usage

## Structure

`MeteredUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreviousUnitBalance` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `NewUnitBalance` | [`MeteredUsageNewUnitBalance`](../../doc/models/containers/metered-usage-new-unit-balance.md) | Required | This is a container for one-of cases. |
| `UsageQuantity` | `int` | Required | - |
| `ComponentId` | `int` | Required | - |
| `ComponentHandle` | `string` | Required | - |
| `Memo` | `string` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

MeteredUsage meteredUsage = new MeteredUsage
{
    PreviousUnitBalance = "previous_unit_balance6",
    NewUnitBalance = MeteredUsageNewUnitBalance.FromNumber(66),
    UsageQuantity = 106,
    ComponentId = 68,
    ComponentHandle = "component_handle0",
    Memo = "memo4",
};
```

