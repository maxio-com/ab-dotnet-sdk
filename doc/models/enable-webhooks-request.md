
# Enable Webhooks Request

## Structure

`EnableWebhooksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WebhooksEnabled` | `bool` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

EnableWebhooksRequest enableWebhooksRequest = new EnableWebhooksRequest
{
    WebhooksEnabled = false,
};
```

