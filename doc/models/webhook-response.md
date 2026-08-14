
# Webhook Response

## Structure

`WebhookResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Webhook` | [`Webhook`](../../doc/models/webhook.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

WebhookResponse webhookResponse = new WebhookResponse
{
    Webhook = new Webhook
    {
        MEvent = "event2",
        Id = 18L,
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        LastError = "last_error4",
        LastErrorAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

