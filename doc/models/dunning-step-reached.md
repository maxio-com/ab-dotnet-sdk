
# Dunning Step Reached

## Structure

`DunningStepReached`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Dunner` | [`DunnerData`](../../doc/models/dunner-data.md) | Required | - |
| `CurrentStep` | [`DunningStepData`](../../doc/models/dunning-step-data.md) | Required | - |
| `NextStep` | [`DunningStepData`](../../doc/models/dunning-step-data.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

DunningStepReached dunningStepReached = new DunningStepReached
{
    Dunner = new DunnerData
    {
        State = "state8",
        SubscriptionId = 194,
        RevenueAtRiskInCents = 98L,
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Attempts = 42,
        LastAttemptedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
    CurrentStep = new DunningStepData
    {
        DayThreshold = 198,
        Action = "action4",
        SendEmail = false,
        SendBccEmail = false,
        SendSms = false,
        EmailBody = "email_body4",
        EmailSubject = "email_subject6",
        SmsBody = "sms_body0",
    },
    NextStep = new DunningStepData
    {
        DayThreshold = 30,
        Action = "action4",
        SendEmail = false,
        SendBccEmail = false,
        SendSms = false,
        EmailBody = "email_body4",
        EmailSubject = "email_subject4",
        SmsBody = "sms_body0",
    },
};
```

