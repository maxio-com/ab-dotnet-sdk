
# Scheduled Renewal Lock in Request

## Structure

`ScheduledRenewalLockInRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LockInAt` | `DateTime` | Required | Date to lock in the renewal. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ScheduledRenewalLockInRequest scheduledRenewalLockInRequest = new ScheduledRenewalLockInRequest
{
    LockInAt = DateTime.Parse("2016-03-13"),
};
```

