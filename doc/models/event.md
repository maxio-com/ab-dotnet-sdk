
# Event

## Structure

`Event`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Key` | [`EventKey`](../../doc/models/event-key.md) | Required | - |
| `Message` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `SubscriptionId` | `int?` | Required | - |
| `CustomerId` | `int?` | Required | - |
| `CreatedAt` | `DateTimeOffset` | Required | - |
| `EventSpecificData` | [`EventEventSpecificData`](../../doc/models/containers/event-event-specific-data.md) | Required | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Globalization;

Event mEvent = new Event
{
    Id = 174L,
    Key = EventKey.SubscriptionGroupCardUpdate,
    Message = "message4",
    SubscriptionId = 28,
    CustomerId = 212,
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
};
```

