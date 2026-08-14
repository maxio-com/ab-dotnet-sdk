
# Delete Subscription Group Response

## Structure

`DeleteSubscriptionGroupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Deleted` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

DeleteSubscriptionGroupResponse deleteSubscriptionGroupResponse = new DeleteSubscriptionGroupResponse
{
    Uid = "uid0",
    Deleted = false,
};
```

