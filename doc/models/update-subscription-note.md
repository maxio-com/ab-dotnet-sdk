
# Update Subscription Note

Updatable fields for Subscription Note

## Structure

`UpdateSubscriptionNote`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Body` | `string` | Required | - |
| `Sticky` | `bool` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateSubscriptionNote updateSubscriptionNote = new UpdateSubscriptionNote
{
    Body = "body2",
    Sticky = false,
};
```

