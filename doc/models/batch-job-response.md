
# Batch Job Response

## Structure

`BatchJobResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Batchjob` | [`BatchJob`](../../doc/models/batch-job.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

BatchJobResponse batchJobResponse = new BatchJobResponse
{
    Batchjob = new BatchJob
    {
        Id = 54,
        FinishedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        RowCount = 62,
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Completed = "completed4",
    },
};
```

