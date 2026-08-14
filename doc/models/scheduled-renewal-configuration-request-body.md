
# Scheduled Renewal Configuration Request Body

## Structure

`ScheduledRenewalConfigurationRequestBody`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartsAt` | `DateTimeOffset?` | Optional | (Optional) Start of the renewal term. |
| `EndsAt` | `DateTimeOffset?` | Optional | (Optional) End of the renewal term. |
| `LockInAt` | `DateTimeOffset?` | Optional | (Optional) Lock-in date for the renewal. |
| `ContractId` | `int?` | Optional | (Optional) Existing contract to associate with the scheduled renewal. Contracts must be enabled for your site. |
| `CreateNewContract` | `bool?` | Optional | (Optional) Set to true to create a new contract when contracts are enabled. Contracts must be enabled for your site. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

ScheduledRenewalConfigurationRequestBody scheduledRenewalConfigurationRequestBody = new ScheduledRenewalConfigurationRequestBody
{
    StartsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LockInAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ContractId = 162,
    CreateNewContract = false,
};
```

