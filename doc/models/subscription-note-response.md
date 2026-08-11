
# Subscription Note Response

## Structure

`SubscriptionNoteResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Note` | [`SubscriptionNote`](../../doc/models/subscription-note.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

SubscriptionNoteResponse subscriptionNoteResponse = new SubscriptionNoteResponse
{
    Note = new SubscriptionNote
    {
        Id = 28,
        Body = "body0",
        SubscriptionId = 138,
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        UpdatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

