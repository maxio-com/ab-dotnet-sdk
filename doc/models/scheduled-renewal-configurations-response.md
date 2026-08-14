
# Scheduled Renewal Configurations Response

## Structure

`ScheduledRenewalConfigurationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ScheduledRenewalConfigurations` | [`List<ScheduledRenewalConfiguration>`](../../doc/models/scheduled-renewal-configuration.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ScheduledRenewalConfigurationsResponse scheduledRenewalConfigurationsResponse = new ScheduledRenewalConfigurationsResponse
{
    ScheduledRenewalConfigurations = new List<ScheduledRenewalConfiguration>
    {
        new ScheduledRenewalConfiguration
        {
            Id = 122,
            SiteId = 48,
            SubscriptionId = 232,
            StartsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            EndsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    },
};
```

