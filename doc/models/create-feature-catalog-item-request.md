
# Create Feature Catalog Item Request

The owning product or component is taken from the URL and must not be included in the request body.

## Structure

`CreateFeatureCatalogItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Feature` | [`Feature2`](../../doc/models/feature-2.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateFeatureCatalogItemRequest createFeatureCatalogItemRequest = new CreateFeatureCatalogItemRequest
{
    Feature = new Feature2
    {
        FeatureTemplateId = 196,
        MValue = "value6",
        PeriodicityInterval = 68,
        PeriodicityUnit = EntitlementPeriodicityUnit.Week,
        PricePointType = FeatureOwnerPricePointType.ProductPricePoint,
        PricePointId = 84,
        PropagateToSubscriptions = false,
    },
};
```

