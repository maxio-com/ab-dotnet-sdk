
# Create or Update Endpoint

Used to Create or Update Endpoint.

## Structure

`CreateOrUpdateEndpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Required | - |
| `WebhookSubscriptions` | [`List<WebhookSubscription>`](../../doc/models/webhook-subscription.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateOrUpdateEndpoint createOrUpdateEndpoint = new CreateOrUpdateEndpoint
{
    Url = "url4",
    WebhookSubscriptions = new List<WebhookSubscription>
    {
        WebhookSubscription.TrialEndNotice,
        WebhookSubscription.SubscriptionStateChange,
        WebhookSubscription.SubscriptionProductChangeScheduled,
    },
};
```

