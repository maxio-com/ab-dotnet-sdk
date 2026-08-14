
# Update Segment Request

## Structure

`UpdateSegmentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Segment` | [`UpdateSegment`](../../doc/models/update-segment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

UpdateSegmentRequest updateSegmentRequest = new UpdateSegmentRequest
{
    Segment = new UpdateSegment
    {
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
};
```

