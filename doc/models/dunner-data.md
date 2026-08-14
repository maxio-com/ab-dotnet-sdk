
# Dunner Data

## Structure

`DunnerData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `string` | Required | - |
| `SubscriptionId` | `int` | Required | - |
| `RevenueAtRiskInCents` | `long` | Required | - |
| `CreatedAt` | `DateTimeOffset` | Required | - |
| `Attempts` | `int` | Required | - |
| `LastAttemptedAt` | `DateTimeOffset` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

DunnerData dunnerData = new DunnerData
{
    State = "state4",
    SubscriptionId = 230,
    RevenueAtRiskInCents = 134L,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Attempts = 6,
    LastAttemptedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

