
# Clone Component Price Point

## Structure

`CloneComponentPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Handle` | `string` | Optional | - |
| `FeatureCatalogItems` | [`List<CloneFeatureCatalogItem>`](../../doc/models/clone-feature-catalog-item.md) | Optional | The features the clone gets. The clone does not copy the source price point's features, so send every feature it should have. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CloneComponentPricePoint cloneComponentPricePoint = new CloneComponentPricePoint
{
    Name = "name4",
    Handle = "handle0",
    FeatureCatalogItems = new List<CloneFeatureCatalogItem>
    {
        new CloneFeatureCatalogItem
        {
            FeatureTemplateId = 8,
            MValue = "value4",
            PeriodicityInterval = 136,
            PeriodicityUnit = EntitlementPeriodicityUnit.Hour,
            GrantExpirationInterval = 60,
            GrantExpirationUnit = GrantExpirationUnit.Month,
        },
    },
};
```

