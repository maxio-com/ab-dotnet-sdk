
# Update Feature Template Request

## Structure

`UpdateFeatureTemplateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Feature` | [`Feature1`](../../doc/models/feature-1.md) | Required | `key` cannot be changed once set. `kind` cannot be changed once any feature catalog item has been created from this template. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateFeatureTemplateRequest updateFeatureTemplateRequest = new UpdateFeatureTemplateRequest
{
    Feature = new Feature1
    {
        Name = "name4",
        Description = "description4",
        Unit = "unit2",
        ValueType = FeatureValueType.Boolean,
        DefaultValue = "default_value4",
    },
};
```

