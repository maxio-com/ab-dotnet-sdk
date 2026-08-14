
# Update Subscription Note Request

Updatable fields for Subscription Note

## Structure

`UpdateSubscriptionNoteRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Note` | [`UpdateSubscriptionNote`](../../doc/models/update-subscription-note.md) | Required | Updatable fields for Subscription Note |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateSubscriptionNoteRequest updateSubscriptionNoteRequest = new UpdateSubscriptionNoteRequest
{
    Note = new UpdateSubscriptionNote
    {
        Body = "body0",
        Sticky = false,
    },
};
```

