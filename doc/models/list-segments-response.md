
# List Segments Response

## Structure

`ListSegmentsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Segments` | [`List<Segment>`](../../doc/models/segment.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListSegmentsResponse listSegmentsResponse = new ListSegmentsResponse
{
    Segments = new List<Segment>
    {
        new Segment
        {
            Id = 50,
            ComponentId = 160,
            PricePointId = 184,
            EventBasedBillingMetricId = 244,
            PricingScheme = PricingScheme.Stairstep,
        },
        new Segment
        {
            Id = 50,
            ComponentId = 160,
            PricePointId = 184,
            EventBasedBillingMetricId = 244,
            PricingScheme = PricingScheme.Stairstep,
        },
    },
};
```

