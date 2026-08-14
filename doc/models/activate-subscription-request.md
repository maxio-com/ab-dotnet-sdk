
# Activate Subscription Request

## Structure

`ActivateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RevertOnFailure` | `bool?` | Optional | You may choose how to handle the activation failure. `true` means do not change the subscription’s state and billing period. `false` means to continue through with the activation and enter an end-of-life state. If this parameter is omitted or `null` is passed it will default to the value set in the site settings (default: `true`). |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ActivateSubscriptionRequest activateSubscriptionRequest = new ActivateSubscriptionRequest
{
    RevertOnFailure = false,
};
```

