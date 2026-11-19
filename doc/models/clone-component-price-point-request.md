
# Clone Component Price Point Request

## Structure

`CloneComponentPricePointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`CloneComponentPricePoint`](../../doc/models/clone-component-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CloneComponentPricePointRequest cloneComponentPricePointRequest = new CloneComponentPricePointRequest
{
    PricePoint = new CloneComponentPricePoint
    {
        Name = "name0",
        Handle = "handle6",
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
            new CloneFeatureCatalogItem
            {
                FeatureTemplateId = 8,
                MValue = "value4",
                PeriodicityInterval = 136,
                PeriodicityUnit = EntitlementPeriodicityUnit.Hour,
                GrantExpirationInterval = 60,
                GrantExpirationUnit = GrantExpirationUnit.Month,
            },
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
    },
};
```

