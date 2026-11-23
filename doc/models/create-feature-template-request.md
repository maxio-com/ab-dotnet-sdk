
# Create Feature Template Request

## Structure

`CreateFeatureTemplateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Feature` | [`Feature`](../../doc/models/feature.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateFeatureTemplateRequest createFeatureTemplateRequest = new CreateFeatureTemplateRequest
{
    Feature = new Feature
    {
        Key = "sso",
        Name = "name4",
        Kind = FeatureKind.UsageLimit,
        Description = "description4",
        Unit = "unit2",
        ValueType = FeatureValueType.Boolean,
        DefaultValue = "default_value4",
        DefaultPeriodicityInterval = 150,
    },
};
```

