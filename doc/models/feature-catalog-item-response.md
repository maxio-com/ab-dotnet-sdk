
# Feature Catalog Item Response

## Structure

`FeatureCatalogItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Feature` | [`FeatureCatalogItem`](../../doc/models/feature-catalog-item.md) | Required | A feature template attached to a specific product or component (or one of their price points), with a concrete value. When a subscriber signs up for or is assigned this product/component, the feature catalog item is provisioned as an entitlement on their subscription. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

FeatureCatalogItemResponse featureCatalogItemResponse = new FeatureCatalogItemResponse
{
    Feature = new FeatureCatalogItem
    {
        Id = 206,
        FeatureTemplateId = 196,
        FeatureKey = "feature_key2",
        FeatureName = "feature_name6",
        FeatureKind = FeatureKind.ServiceRight,
    },
};
```

