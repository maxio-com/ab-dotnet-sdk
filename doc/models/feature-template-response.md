
# Feature Template Response

## Structure

`FeatureTemplateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Feature` | [`FeatureTemplate`](../../doc/models/feature-template.md) | Required | A feature that can be granted to subscribers, defined once at the site level and then attached to products or components. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

FeatureTemplateResponse featureTemplateResponse = new FeatureTemplateResponse
{
    Feature = new FeatureTemplate
    {
        Id = 206,
        Key = "sso",
        Name = "Single Sign-On",
        Description = "description4",
        Kind = FeatureKind.UsageLimit,
    },
};
```

