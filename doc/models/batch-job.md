
# Batch Job

## Structure

`BatchJob`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FinishedAt` | `DateTimeOffset?` | Optional | - |
| `RowCount` | `int?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `Completed` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

BatchJob batchJob = new BatchJob
{
    Id = 60,
    FinishedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    RowCount = 68,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Completed = "completed6",
};
```

