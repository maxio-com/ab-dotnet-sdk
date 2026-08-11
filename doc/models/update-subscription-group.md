
# Update Subscription Group

## Structure

`UpdateSubscriptionGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MemberIds` | `List<int>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

UpdateSubscriptionGroup updateSubscriptionGroup = new UpdateSubscriptionGroup
{
    MemberIds = new List<int>
    {
        248,
        249,
        250,
    },
};
```

