
# Create Subscription Group

## Structure

`CreateSubscriptionGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int` | Required | - |
| `MemberIds` | `List<int>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateSubscriptionGroup createSubscriptionGroup = new CreateSubscriptionGroup
{
    SubscriptionId = 204,
    MemberIds = new List<int>
    {
        48,
    },
};
```

