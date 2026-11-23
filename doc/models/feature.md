
# Feature

## Structure

`Feature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Required | A unique, lowercase, underscore-separated identifier for the feature. Immutable once set. |
| `Name` | `string` | Required | The display name of the feature. |
| `Description` | `string` | Optional | - |
| `Kind` | [`FeatureKind`](../../doc/models/feature-kind.md) | Required | The behavior of a feature:<br><br>- `access_right`: a boolean entitlement. A subscriber either has access or does not.<br>- `usage_limit`: a quantified allowance measured over a recurring period (for example, "10,000 API calls per month").<br>- `service_right`: a free-form value (text, boolean, or number) that isn't a simple access flag or a metered limit. |
| `Unit` | `string` | Optional | Required when `kind` is `usage_limit`. |
| `ValueType` | [`FeatureValueType?`](../../doc/models/feature-value-type.md) | Optional | Required when `kind` is `service_right`. Ignored for other kinds, where it is inferred automatically. |
| `DefaultValue` | `string` | Optional | - |
| `DefaultPeriodicityInterval` | `int?` | Optional | Only valid when `kind` is `usage_limit`. |
| `DefaultPeriodicityUnit` | [`EntitlementPeriodicityUnit?`](../../doc/models/entitlement-periodicity-unit.md) | Optional | Only valid when `kind` is `usage_limit`. Must be set together with `default_periodicity_interval`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Feature feature = new Feature
{
    Key = "sso",
    Name = "name4",
    Kind = FeatureKind.UsageLimit,
    Description = "description4",
    Unit = "unit2",
    ValueType = FeatureValueType.Boolean,
    DefaultValue = "default_value4",
    DefaultPeriodicityInterval = 150,
};
```

