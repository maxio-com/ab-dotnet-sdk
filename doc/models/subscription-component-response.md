
# Subscription Component Response

## Structure

`SubscriptionComponentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Component` | [`SubscriptionComponent`](../../doc/models/subscription-component.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionComponentResponse subscriptionComponentResponse = new SubscriptionComponentResponse
{
    Component = new SubscriptionComponent
    {
        Id = 80,
        Name = "name8",
        Kind = ComponentKind.EventBasedComponent,
        UnitName = "unit_name0",
        Enabled = false,
    },
};
```

