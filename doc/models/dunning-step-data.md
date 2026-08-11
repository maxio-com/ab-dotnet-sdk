
# Dunning Step Data

## Structure

`DunningStepData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DayThreshold` | `int` | Required | - |
| `Action` | `string` | Required | - |
| `EmailBody` | `string` | Optional | - |
| `EmailSubject` | `string` | Optional | - |
| `SendEmail` | `bool` | Required | - |
| `SendBccEmail` | `bool` | Required | - |
| `SendSms` | `bool` | Required | - |
| `SmsBody` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

DunningStepData dunningStepData = new DunningStepData
{
    DayThreshold = 206,
    Action = "action6",
    SendEmail = false,
    SendBccEmail = false,
    SendSms = false,
    EmailBody = "email_body6",
    EmailSubject = "email_subject6",
    SmsBody = "sms_body8",
};
```

