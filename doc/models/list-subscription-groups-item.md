
# List Subscription Groups Item

## Structure

`ListSubscriptionGroupsItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Scheme` | `int?` | Optional | - |
| `CustomerId` | `int?` | Optional | - |
| `PaymentProfileId` | `int?` | Optional | - |
| `SubscriptionIds` | `List<int>` | Optional | - |
| `PrimarySubscriptionId` | `int?` | Optional | - |
| `NextAssessmentAt` | `DateTimeOffset?` | Optional | - |
| `State` | `string` | Optional | - |
| `CancelAtEndOfPeriod` | `bool?` | Optional | - |
| `AccountBalances` | [`SubscriptionGroupBalances`](../../doc/models/subscription-group-balances.md) | Optional | - |
| `GroupType` | [`GroupType?`](../../doc/models/group-type.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListSubscriptionGroupsItem listSubscriptionGroupsItem = new ListSubscriptionGroupsItem
{
    Uid = "uid0",
    Scheme = 228,
    CustomerId = 248,
    PaymentProfileId = 100,
    SubscriptionIds = new List<int>
    {
        102,
        103,
    },
};
```

