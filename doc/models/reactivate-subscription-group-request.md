
# Reactivate Subscription Group Request

## Structure

`ReactivateSubscriptionGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Resume` | `bool?` | Optional | - |
| `ResumeMembers` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ReactivateSubscriptionGroupRequest reactivateSubscriptionGroupRequest = new ReactivateSubscriptionGroupRequest
{
    Resume = false,
    ResumeMembers = false,
};
```

