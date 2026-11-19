
# Event Based Billing Segment Single Error

The key of the object would be a number (an index in the request array) where the error occurred. In the value object, the key represents the field and the value is an array with error messages. In most cases, this object would contain just one key.

## Structure

`EventBasedBillingSegmentSingleError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | `List<string>` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

EventBasedBillingSegmentSingleError eventBasedBillingSegmentSingleError = new EventBasedBillingSegmentSingleError
{
    PricePoint = new List<string>
    {
        "price_point0",
    },
};
```

