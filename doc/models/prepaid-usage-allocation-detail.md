
# Prepaid Usage Allocation Detail

## Structure

`PrepaidUsageAllocationDetail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllocationId` | `int?` | Optional | - |
| `ChargeId` | `int?` | Optional | - |
| `UsageQuantity` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PrepaidUsageAllocationDetail prepaidUsageAllocationDetail = new PrepaidUsageAllocationDetail
{
    AllocationId = 144,
    ChargeId = 214,
    UsageQuantity = 140,
};
```

