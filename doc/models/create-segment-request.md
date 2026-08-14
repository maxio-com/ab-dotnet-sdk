
# Create Segment Request

## Structure

`CreateSegmentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Segment` | [`CreateSegment`](../../doc/models/create-segment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateSegmentRequest createSegmentRequest = new CreateSegmentRequest
{
    Segment = new CreateSegment
    {
        PricingScheme = PricingScheme.Stairstep,
        SegmentProperty1Value = CreateSegmentSegmentProperty1Value.FromString("String1"),
        SegmentProperty2Value = CreateSegmentSegmentProperty2Value.FromString("String3"),
        SegmentProperty3Value = CreateSegmentSegmentProperty3Value.FromString("String1"),
        SegmentProperty4Value = CreateSegmentSegmentProperty4Value.FromString("String5"),
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
};
```

