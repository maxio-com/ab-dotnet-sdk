
# Send Email

## Structure

`SendEmail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CanExecute` | `bool` | Required | - |
| `Url` | `string` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SendEmail sendEmail = new SendEmail
{
    CanExecute = false,
    Url = "url2",
};
```

