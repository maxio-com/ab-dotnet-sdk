
# Available Actions

## Structure

`AvailableActions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SendEmail` | [`SendEmail`](../../doc/models/send-email.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AvailableActions availableActions = new AvailableActions
{
    SendEmail = new SendEmail
    {
        CanExecute = false,
        Url = "url0",
    },
};
```

