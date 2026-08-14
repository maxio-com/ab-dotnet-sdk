
# Bulk Create Segments

## Structure

`BulkCreateSegments`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Segments` | [`List<CreateSegment>`](../../doc/models/create-segment.md) | Optional | **Constraints**: *Maximum Items*: `2000` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

BulkCreateSegments bulkCreateSegments = new BulkCreateSegments
{
    Segments = new List<CreateSegment>
    {
        new CreateSegment
        {
            PricingScheme = PricingScheme.Stairstep,
            SegmentProperty1Value = CreateSegmentSegmentProperty1Value.FromString("String3"),
            SegmentProperty2Value = CreateSegmentSegmentProperty2Value.FromString("String5"),
            SegmentProperty3Value = CreateSegmentSegmentProperty3Value.FromString("String3"),
            SegmentProperty4Value = CreateSegmentSegmentProperty4Value.FromString("String7"),
            Prices = new List<CreateOrUpdateSegmentPrice>
            {
                new CreateOrUpdateSegmentPrice
                {
                    UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
                    StartingQuantity = 64,
                    EndingQuantity = 38,
                },
                new CreateOrUpdateSegmentPrice
                {
                    UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
                    StartingQuantity = 64,
                    EndingQuantity = 38,
                },
                new CreateOrUpdateSegmentPrice
                {
                    UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
                    StartingQuantity = 64,
                    EndingQuantity = 38,
                },
            },
        },
    },
};
```

