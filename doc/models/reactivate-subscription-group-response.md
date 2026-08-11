
# Reactivate Subscription Group Response

## Structure

`ReactivateSubscriptionGroupResponse`

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

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ReactivateSubscriptionGroupResponse reactivateSubscriptionGroupResponse = new ReactivateSubscriptionGroupResponse
{
    Uid = "uid0",
    Scheme = 10,
    CustomerId = 30,
    PaymentProfileId = 62,
    SubscriptionIds = new List<int>
    {
        140,
        141,
        142,
    },
};
```

