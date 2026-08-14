
# Subscription Group Members Array Error

## Structure

`SubscriptionGroupMembersArrayError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Members` | `List<string>` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroupMembersArrayError subscriptionGroupMembersArrayError = new SubscriptionGroupMembersArrayError
{
    Members = new List<string>
    {
        "members6",
    },
};
```

