
# Event Response

## Structure

`EventResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Event` | [`Event`](../../doc/models/event.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Globalization;

EventResponse eventResponse = new EventResponse
{
    MEvent = new Event
    {
        Id = 242L,
        Key = EventKey.SubscriptionRemovedFromGroup,
        Message = "message0",
        SubscriptionId = 96,
        CustomerId = 24,
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        EventSpecificData = EventEventSpecificData.FromSubscriptionProductChange(
            new SubscriptionProductChange
            {
                PreviousProductId = 126,
                NewProductId = 12,
            }
        ),
    },
};
```

