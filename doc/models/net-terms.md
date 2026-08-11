
# Net Terms

## Structure

`NetTerms`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DefaultNetTerms` | `int?` | Optional | **Default**: `0` |
| `AutomaticNetTerms` | `int?` | Optional | **Default**: `0` |
| `RemittanceNetTerms` | `int?` | Optional | **Default**: `0` |
| `NetTermsOnRemittanceSignupsEnabled` | `bool?` | Optional | **Default**: `false` |
| `CustomNetTermsEnabled` | `bool?` | Optional | **Default**: `false` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

NetTerms netTerms = new NetTerms
{
    DefaultNetTerms = 0,
    AutomaticNetTerms = 0,
    RemittanceNetTerms = 0,
    NetTermsOnRemittanceSignupsEnabled = false,
    CustomNetTermsEnabled = false,
};
```

