
# Offer Signup Page

## Structure

`OfferSignupPage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Nickname` | `string` | Optional | - |
| `Enabled` | `bool?` | Optional | - |
| `ReturnUrl` | `string` | Optional | - |
| `ReturnParams` | `string` | Optional | - |
| `Url` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

OfferSignupPage offerSignupPage = new OfferSignupPage
{
    Id = 102,
    Nickname = "nickname6",
    Enabled = false,
    ReturnUrl = "return_url6",
    ReturnParams = "return_params8",
};
```

