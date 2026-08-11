
# List Subscription Groups Response

## Structure

`ListSubscriptionGroupsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionGroups` | [`List<ListSubscriptionGroupsItem>`](../../doc/models/list-subscription-groups-item.md) | Optional | - |
| `Meta` | [`ListSubscriptionGroupsMeta`](../../doc/models/list-subscription-groups-meta.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListSubscriptionGroupsResponse listSubscriptionGroupsResponse = new ListSubscriptionGroupsResponse
{
    SubscriptionGroups = new List<ListSubscriptionGroupsItem>
    {
        new ListSubscriptionGroupsItem
        {
            Uid = "uid2",
            Scheme = 166,
            CustomerId = 186,
            PaymentProfileId = 162,
            SubscriptionIds = new List<int>
            {
                40,
            },
        },
    },
    Meta = new ListSubscriptionGroupsMeta
    {
        CurrentPage = 126,
        TotalCount = 150,
    },
};
```

