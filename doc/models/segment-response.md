
# Segment Response

## Structure

`SegmentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Segment` | [`Segment`](../../doc/models/segment.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SegmentResponse segmentResponse = new SegmentResponse
{
    Segment = new Segment
    {
        Id = 118,
        ComponentId = 228,
        PricePointId = 4,
        EventBasedBillingMetricId = 56,
        PricingScheme = PricingScheme.Stairstep,
    },
};
```

