
# Update Feature Catalog Item Request

## Structure

`UpdateFeatureCatalogItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Feature` | [`Feature3`](../../doc/models/feature-3.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateFeatureCatalogItemRequest updateFeatureCatalogItemRequest = new UpdateFeatureCatalogItemRequest
{
    Feature = new Feature3
    {
        MValue = "value6",
        PeriodicityInterval = 68,
        PeriodicityUnit = EntitlementPeriodicityUnit.Week,
        PropagateToSubscriptions = false,
    },
};
```

