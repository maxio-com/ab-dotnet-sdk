
# Cancellation Options

## Structure

`CancellationOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CancellationMessage` | `string` | Optional | An indication as to why the subscription is being canceled. For your internal use. |
| `ReasonCode` | `string` | Optional | The reason code associated with the cancellation. Use the [List Reason Codes](../../doc/controllers/reason-codes.md#list-reason-codes) endpoint to retrieve the reason codes associated with your site. |
| `CancelAtEndOfPeriod` | `bool?` | Optional | When true, the subscription is cancelled at the current period end instead of immediately. To use this option, the Schedule Subscription Cancellation feature must be enabled on your site. |
| `ScheduledCancellationAt` | `DateTimeOffset?` | Optional | Schedules the cancellation on the provided date. This option is not applicable for prepaid subscriptions. To use this option, the Schedule Subscription Cancellation feature must be enabled on your site. |
| `RefundPrepaymentAccountBalance` | `bool?` | Optional | Applies to prepaid subscriptions. When true, which is the default, the remaining prepaid balance is refunded as part of cancellation processing. When false, prepaid balance is not refunded as part of cancellation processing. To use this option, the Schedule Subscription Cancellation feature must be enabled on your site. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

CancellationOptions cancellationOptions = new CancellationOptions
{
    CancellationMessage = "cancellation_message0",
    ReasonCode = "reason_code6",
    CancelAtEndOfPeriod = false,
    ScheduledCancellationAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    RefundPrepaymentAccountBalance = false,
};
```

