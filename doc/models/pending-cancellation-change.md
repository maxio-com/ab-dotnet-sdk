
# Pending Cancellation Change

## Structure

`PendingCancellationChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CancellationState` | `string` | Required | - |
| `CancelsAt` | `DateTimeOffset` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

PendingCancellationChange pendingCancellationChange = new PendingCancellationChange
{
    CancellationState = "cancellation_state0",
    CancelsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

