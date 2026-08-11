
# Add Subscription to a Group

## Structure

`AddSubscriptionToAGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Group` | [`GroupSettings`](../../doc/models/group-settings.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AddSubscriptionToAGroup addSubscriptionToAGroup = new AddSubscriptionToAGroup
{
    MGroup = new GroupSettings
    {
        Target = new GroupTarget
        {
            Type = GroupTargetType.Parent,
            Id = 236,
        },
        Billing = new GroupBilling
        {
            Accrue = false,
            AlignDate = false,
            Prorate = false,
        },
    },
};
```

