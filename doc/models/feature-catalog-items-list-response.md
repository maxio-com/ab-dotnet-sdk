
# Feature Catalog Items List Response

## Structure

`FeatureCatalogItemsListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Features` | [`List<FeatureCatalogItem>`](../../doc/models/feature-catalog-item.md) | Required | - |
| `SubscriptionsCount` | `int` | Required | The number of subscriptions on this product/component that would be affected if a feature catalog item change were propagated with `propagate_to_subscriptions=true`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

FeatureCatalogItemsListResponse featureCatalogItemsListResponse = new FeatureCatalogItemsListResponse
{
    Features = new List<FeatureCatalogItem>
    {
        new FeatureCatalogItem
        {
            Id = 174,
            FeatureTemplateId = 164,
            FeatureKey = "feature_key2",
            FeatureName = "feature_name6",
            FeatureKind = FeatureKind.AccessRight,
        },
    },
    SubscriptionsCount = 22,
};
```

