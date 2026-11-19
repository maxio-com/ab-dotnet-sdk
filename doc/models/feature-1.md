
# Feature 1

`key` cannot be changed once set. `kind` cannot be changed once any feature catalog item has been created from this template.

## Structure

`Feature1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Unit` | `string` | Optional | - |
| `ValueType` | [`FeatureValueType?`](../../doc/models/feature-value-type.md) | Optional | The data type of a feature's value. For `access_right` features this is always `boolean`, and for `usage_limit` features this is always `numeric`. For `service_right` features, you choose the value type explicitly. |
| `DefaultValue` | `string` | Optional | - |
| `DefaultPeriodicityInterval` | `int?` | Optional | - |
| `DefaultPeriodicityUnit` | [`EntitlementPeriodicityUnit?`](../../doc/models/entitlement-periodicity-unit.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Feature1 feature1 = new Feature1
{
    Name = "name8",
    Description = "description8",
    Unit = "unit6",
    ValueType = FeatureValueType.Text,
    DefaultValue = "default_value8",
};
```

