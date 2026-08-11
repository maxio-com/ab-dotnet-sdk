
# Scheduled Renewal Configuration Response

## Structure

`ScheduledRenewalConfigurationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ScheduledRenewalConfiguration` | [`ScheduledRenewalConfiguration`](../../doc/models/scheduled-renewal-configuration.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

ScheduledRenewalConfigurationResponse scheduledRenewalConfigurationResponse = new ScheduledRenewalConfigurationResponse
{
    ScheduledRenewalConfiguration = new ScheduledRenewalConfiguration
    {
        Id = 134,
        SiteId = 60,
        SubscriptionId = 244,
        StartsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        EndsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

