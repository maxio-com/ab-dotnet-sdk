
# Feature Templates List Response

## Structure

`FeatureTemplatesListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Items` | [`List<FeatureTemplate>`](../../doc/models/feature-template.md) | Required | - |
| `TotalCount` | `int` | Required | Total number of feature templates matching the filters, across all pages. |
| `ArchivedCount` | `int` | Required | Number of archived feature templates matching the filters. Returned as `0` unless the active result set is empty or `status=archived` was requested. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

FeatureTemplatesListResponse featureTemplatesListResponse = new FeatureTemplatesListResponse
{
    Items = new List<FeatureTemplate>
    {
        new FeatureTemplate
        {
            Id = 66,
            Key = "sso",
            Name = "Single Sign-On",
            Description = "description2",
            Kind = FeatureKind.AccessRight,
        },
    },
    TotalCount = 54,
    ArchivedCount = 78,
};
```

