
# Feature Value Type

The data type of a feature's value. For `access_right` features this is always `boolean`, and for `usage_limit` features this is always `numeric`. For `service_right` features, you choose the value type explicitly.

## Enumeration

`FeatureValueType`

## Fields

| Name |
|  --- |
| `Text` |
| `Boolean` |
| `Numeric` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

FeatureValueType featureValueType = FeatureValueType.Text;
```

