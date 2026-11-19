
# Feature 2

## Structure

`Feature2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FeatureTemplateId` | `int` | Required | The id of the feature template to attach. |
| `MValue` | `string` | Optional | The value granted. Defaults to the feature template's `default_value`; required when the template has none. |
| `PeriodicityInterval` | `int?` | Optional | Required for `usage_limit` features, unless the feature template has a default periodicity, which is used when omitted. Must be omitted for other kinds. |
| `PeriodicityUnit` | [`EntitlementPeriodicityUnit?`](../../doc/models/entitlement-periodicity-unit.md) | Optional | Required for `usage_limit` features, unless the feature template has a default periodicity, which is used when omitted. Must be omitted for other kinds. |
| `PricePointType` | [`FeatureOwnerPricePointType?`](../../doc/models/feature-owner-price-point-type.md) | Optional | Set together with `price_point_id` to scope the feature catalog item to a single price point. Omit both to create a product/component-level item, which is a template: it is copied onto price points created afterwards (except bulk-created ones; Clone Component Price Point applies only the items sent with it), but not added to price points that already exist or to their subscribers. |
| `PricePointId` | `int?` | Optional | - |
| `PropagateToSubscriptions` | `bool?` | Optional | Applies to price-point-scoped items only. When `true`, existing subscriptions on that price point are granted an entitlement for this feature by a background job shortly after, instead of at their next subscription change. When `false` (default) and the price point already has subscribers, the feature is created on a clone of the price point instead, and existing subscribers are unaffected. On a product/component-level item it has no effect, except when the call restores that item's archived price-point copies (creating an item again for a feature template whose item was archived): then `true` grants the feature to those price points' subscribers, and without it the call returns `422` if any of them lack the feature.<br><br>**Default**: `false` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Feature2 feature2 = new Feature2
{
    FeatureTemplateId = 90,
    MValue = "value4",
    PeriodicityInterval = 218,
    PeriodicityUnit = EntitlementPeriodicityUnit.Hour,
    PricePointType = FeatureOwnerPricePointType.ProductPricePoint,
    PricePointId = 22,
    PropagateToSubscriptions = false,
};
```

