
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

## Example (as JSON)

```json
{
  "day_threshold": 88,
  "action": "action4",
  "email_body": "email_body4",
  "email_subject": "email_subject4",
  "send_email": false,
  "send_bcc_email": false,
  "send_sms": false,
  "sms_body": "sms_body0"
}
```

