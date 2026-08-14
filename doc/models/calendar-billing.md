
# Calendar Billing

(Optional). Cannot be used when also specifying next_billing_at.

## Structure

`CalendarBilling`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SnapDay` | [`CalendarBillingSnapDay`](../../doc/models/containers/calendar-billing-snap-day.md) | Optional | This is a container for one-of cases. |
| `CalendarBillingFirstCharge` | [`FirstChargeType?`](../../doc/models/first-charge-type.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CalendarBilling calendarBilling = new CalendarBilling
{
    SnapDay = CalendarBillingSnapDay.FromNumber(200),
    CalendarBillingFirstCharge = FirstChargeType.Delayed,
};
```

