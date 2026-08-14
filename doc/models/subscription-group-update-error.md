
# Subscription Group Update Error

## Structure

`SubscriptionGroupUpdateError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Members` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroupUpdateError subscriptionGroupUpdateError = new SubscriptionGroupUpdateError
{
    Members = new List<string>
    {
        "members6",
        "members7",
    },
};
```

