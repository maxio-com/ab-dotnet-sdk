
# Update Subscription Group Request

## Structure

`UpdateSubscriptionGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionGroup` | [`UpdateSubscriptionGroup`](../../doc/models/update-subscription-group.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

UpdateSubscriptionGroupRequest updateSubscriptionGroupRequest = new UpdateSubscriptionGroupRequest
{
    SubscriptionGroup = new UpdateSubscriptionGroup
    {
        MemberIds = new List<int>
        {
            164,
            165,
        },
    },
};
```

