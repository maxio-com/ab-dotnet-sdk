
# Bulk Update Segments

## Structure

`BulkUpdateSegments`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Segments` | [`List<BulkUpdateSegmentsItem>`](../../doc/models/bulk-update-segments-item.md) | Optional | **Constraints**: *Maximum Items*: `1000` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

BulkUpdateSegments bulkUpdateSegments = new BulkUpdateSegments
{
    Segments = new List<BulkUpdateSegmentsItem>
    {
        new BulkUpdateSegmentsItem
        {
            Id = 50,
            PricingScheme = PricingScheme.Stairstep,
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
        new BulkUpdateSegmentsItem
        {
            Id = 50,
            PricingScheme = PricingScheme.Stairstep,
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

