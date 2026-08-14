
# Pause Request

Allows you to pause a Subscription.

## Structure

`PauseRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hold` | [`AutoResume`](../../doc/models/auto-resume.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

PauseRequest pauseRequest = new PauseRequest
{
    Hold = new AutoResume
    {
        AutomaticallyResumeAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

