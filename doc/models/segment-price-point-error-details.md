
# Segment Price Point Error Details

Price-point validation error details for segment writes.

## Structure

`SegmentPricePointErrorDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | `List<string>` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SegmentPricePointErrorDetails segmentPricePointErrorDetails = new SegmentPricePointErrorDetails
{
    PricePoint = new List<string>
    {
        "price_point2",
    },
};
```

