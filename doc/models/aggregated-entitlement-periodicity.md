
# Aggregated Entitlement Periodicity

## Structure

`AggregatedEntitlementPeriodicity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Interval` | `int?` | Optional | - |
| `Unit` | [`EntitlementPeriodicityUnit?`](../../doc/models/entitlement-periodicity-unit.md) | Optional | The recurring window over which a `usage_limit` feature's allowance resets. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AggregatedEntitlementPeriodicity aggregatedEntitlementPeriodicity = new AggregatedEntitlementPeriodicity
{
    Interval = 128,
    Unit = EntitlementPeriodicityUnit.Year,
};
```

