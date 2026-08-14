
# Create Subscription Group Request

## Structure

`CreateSubscriptionGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionGroup` | [`CreateSubscriptionGroup`](../../doc/models/create-subscription-group.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateSubscriptionGroupRequest createSubscriptionGroupRequest = new CreateSubscriptionGroupRequest
{
    SubscriptionGroup = new CreateSubscriptionGroup
    {
        SubscriptionId = 36,
        MemberIds = new List<int>
        {
            164,
            165,
        },
    },
};
```

