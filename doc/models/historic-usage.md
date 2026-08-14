
# Historic Usage

(Optional) For Event Based Components. If the `include=historic_usages` query param is provided, the last ten billing periods will be returned.

## Structure

`HistoricUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalUsageQuantity` | `double?` | Optional | Total usage of a component for billing period |
| `BillingPeriodStartsAt` | `DateTimeOffset?` | Optional | Start date of billing period |
| `BillingPeriodEndsAt` | `DateTimeOffset?` | Optional | End date of billing period |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

HistoricUsage historicUsage = new HistoricUsage
{
    TotalUsageQuantity = 140.74,
    BillingPeriodStartsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    BillingPeriodEndsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

