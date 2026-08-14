
# Cancel Grouped Subscriptions Request

## Structure

`CancelGroupedSubscriptionsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargeUnbilledUsage` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CancelGroupedSubscriptionsRequest cancelGroupedSubscriptionsRequest = new CancelGroupedSubscriptionsRequest
{
    ChargeUnbilledUsage = false,
};
```

