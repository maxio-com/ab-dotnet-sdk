
# Clone Feature Catalog Item

A feature to put on the cloned price point. Requires Entitlements to be enabled for the site; ignored otherwise.

Unlike Create Feature Catalog Item, nothing falls back to the feature template's defaults: send `value`, and for a `usage_limit` feature its periodicity (and any grant expiration) explicitly. If any item can't be applied, for example a missing `value`, a `usage_limit` item without periodicity, or an archived or unknown feature template, the whole clone fails with `422` and nothing is created.

## Structure

`CloneFeatureCatalogItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FeatureTemplateId` | `int` | Required | - |
| `MValue` | `string` | Required | - |
| `PeriodicityInterval` | `int?` | Optional | Required for `usage_limit` features; must be omitted for other kinds. |
| `PeriodicityUnit` | [`EntitlementPeriodicityUnit?`](../../doc/models/entitlement-periodicity-unit.md) | Optional | Required for `usage_limit` features; must be omitted for other kinds. |
| `GrantExpirationInterval` | `int?` | Optional | `usage_limit` features only. A positive number of `grant_expiration_unit`s; required with `day` or `month`, and must be omitted with `until_next_refill`. |
| `GrantExpirationUnit` | [`GrantExpirationUnit?`](../../doc/models/grant-expiration-unit.md) | Optional | `usage_limit` features only. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CloneFeatureCatalogItem cloneFeatureCatalogItem = new CloneFeatureCatalogItem
{
    FeatureTemplateId = 212,
    MValue = "value6",
    PeriodicityInterval = 84,
    PeriodicityUnit = EntitlementPeriodicityUnit.Week,
    GrantExpirationInterval = 8,
    GrantExpirationUnit = GrantExpirationUnit.UntilNextRefill,
};
```

