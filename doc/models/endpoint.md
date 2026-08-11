
# Endpoint

## Structure

`Endpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Url` | `string` | Optional | - |
| `SiteId` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `WebhookSubscriptions` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

Endpoint endpoint = new Endpoint
{
    Id = 202,
    Url = "url2",
    SiteId = 128,
    Status = "status0",
    WebhookSubscriptions = new List<string>
    {
        "webhook_subscriptions4",
    },
};
```

