
# Create or Update Endpoint Request

Used to Create or Update Endpoint.

## Structure

`CreateOrUpdateEndpointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Endpoint` | [`CreateOrUpdateEndpoint`](../../doc/models/create-or-update-endpoint.md) | Required | Used to Create or Update Endpoint. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateOrUpdateEndpointRequest createOrUpdateEndpointRequest = new CreateOrUpdateEndpointRequest
{
    Endpoint = new CreateOrUpdateEndpoint
    {
        Url = "url2",
        WebhookSubscriptions = new List<WebhookSubscription>
        {
            WebhookSubscription.StatementClosed,
        },
    },
};
```

