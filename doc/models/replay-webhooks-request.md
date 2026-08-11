
# Replay Webhooks Request

## Structure

`ReplayWebhooksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ids` | `List<long>` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ReplayWebhooksRequest replayWebhooksRequest = new ReplayWebhooksRequest
{
    Ids = new List<long>
    {
        209L,
        210L,
        211L,
    },
};
```

