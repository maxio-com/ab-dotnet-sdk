
# Feature Catalog Item

A feature template attached to a specific product or component (or one of their price points), with a concrete value. When a subscriber signs up for or is assigned this product/component, the feature catalog item is provisioned as an entitlement on their subscription.

## Structure

`FeatureCatalogItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FeatureTemplateId` | `int?` | Optional | The id of the feature template this item was created from. |
| `FeatureKey` | `string` | Optional | The `key` of the parent feature template. |
| `FeatureName` | `string` | Optional | The `name` of the parent feature template. |
| `FeatureKind` | [`FeatureKind?`](../../doc/models/feature-kind.md) | Optional | The behavior of a feature:<br><br>- `access_right`: a boolean entitlement. A subscriber either has access or does not.<br>- `usage_limit`: a quantified allowance measured over a recurring period (for example, "10,000 API calls per month").<br>- `service_right`: a free-form value (text, boolean, or number) that isn't a simple access flag or a metered limit. |
| `MValue` | `string` | Optional | The value granted by this feature catalog item. Interpreted according to `feature_kind`: `"true"`/`"false"` for `access_right`, a numeric string for `usage_limit`, or any string for `service_right` (shaped by the feature template's `value_type`). |
| `PeriodicityInterval` | `int?` | Optional | Set when `feature_kind` is `usage_limit`; `null` otherwise. |
| `PeriodicityUnit` | [`EntitlementPeriodicityUnit?`](../../doc/models/entitlement-periodicity-unit.md) | Optional | Set when `feature_kind` is `usage_limit`; `null` otherwise. |
| `PricePointType` | [`FeatureOwnerPricePointType?`](../../doc/models/feature-owner-price-point-type.md) | Optional | `null` when this feature catalog item applies to every price point of its owning product/component. Set when the feature catalog item is an override for one specific price point. |
| `PricePointId` | `int?` | Optional | Set together with `price_point_type` for price-point-specific overrides. |
| `ArchivedAt` | `DateTimeOffset?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

FeatureCatalogItem featureCatalogItem = new FeatureCatalogItem
{
    Id = 52,
    FeatureTemplateId = 42,
    FeatureKey = "feature_key6",
    FeatureName = "feature_name0",
    FeatureKind = FeatureKind.UsageLimit,
};
```

