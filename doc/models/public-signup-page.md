
# Public Signup Page

## Structure

`PublicSignupPage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The id of the signup page (public_signup_pages only) |
| `ReturnUrl` | `string` | Optional | The url to which a customer will be returned after a successful signup (public_signup_pages only). |
| `ReturnParams` | `string` | Optional | The params to be appended to the return_url (public_signup_pages only) |
| `Url` | `string` | Optional | The url where the signup page can be viewed (public_signup_pages only). |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PublicSignupPage publicSignupPage = new PublicSignupPage
{
    Id = 20,
    ReturnUrl = "return_url0",
    ReturnParams = "return_params2",
    Url = "url8",
};
```

