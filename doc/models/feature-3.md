
# Feature 3

## Structure

`Feature3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | - |
| `PeriodicityInterval` | `int?` | Optional | - |
| `PeriodicityUnit` | [`EntitlementPeriodicityUnit?`](../../doc/models/entitlement-periodicity-unit.md) | Optional | - |
| `PropagateToSubscriptions` | `bool?` | Optional | When `true`, existing subscriptions on the item's price point are updated with the new `value`/periodicity by a background job shortly after. Has no effect on a product/component-level item. When `false` (default) and the item's price point already has subscribers, the update is made on a clone of the price point instead, and existing subscribers are unaffected.<br><br>**Default**: `false` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Feature3 feature3 = new Feature3
{
    MValue = "value0",
    PeriodicityInterval = 222,
    PeriodicityUnit = EntitlementPeriodicityUnit.Day,
    PropagateToSubscriptions = false,
};
```

