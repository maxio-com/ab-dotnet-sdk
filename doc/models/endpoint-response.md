
# Endpoint Response

## Structure

`EndpointResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Endpoint` | [`Endpoint`](../../doc/models/endpoint.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

EndpointResponse endpointResponse = new EndpointResponse
{
    Endpoint = new Endpoint
    {
        Id = 202,
        Url = "url2",
        SiteId = 128,
        Status = "status0",
        WebhookSubscriptions = new List<string>
        {
            "webhook_subscriptions4",
        },
    },
};
```

