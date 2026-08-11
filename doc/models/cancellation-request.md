
# Cancellation Request

## Structure

`CancellationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscription` | [`CancellationOptions`](../../doc/models/cancellation-options.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

CancellationRequest cancellationRequest = new CancellationRequest
{
    Subscription = new CancellationOptions
    {
        CancellationMessage = "cancellation_message2",
        ReasonCode = "reason_code8",
        CancelAtEndOfPeriod = false,
        ScheduledCancellationAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        RefundPrepaymentAccountBalance = false,
    },
};
```

