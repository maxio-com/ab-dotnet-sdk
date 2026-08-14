
# Payer Attributes

## Structure

`PayerAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `CcEmails` | `string` | Optional | - |
| `Organization` | `string` | Optional | - |
| `Reference` | `string` | Optional | - |
| `Address` | `string` | Optional | - |
| `Address2` | `string` | Optional | - |
| `City` | `string` | Optional | - |
| `State` | `string` | Optional | - |
| `Zip` | `string` | Optional | - |
| `Country` | `string` | Optional | - |
| `Phone` | `string` | Optional | - |
| `Locale` | `string` | Optional | - |
| `VatNumber` | `string` | Optional | - |
| `TaxExempt` | `bool?` | Optional | - |
| `TaxExemptReason` | `string` | Optional | - |
| `Metafields` | `Dictionary<string, string>` | Optional | (Optional) A set of key/value pairs representing custom fields and their values. Metafields will be created “on-the-fly” in your site for a given key, if they have not been created yet. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

PayerAttributes payerAttributes = new PayerAttributes
{
    FirstName = "first_name2",
    LastName = "last_name0",
    Email = "email4",
    CcEmails = "cc_emails8",
    Organization = "organization4",
    Metafields = new Dictionary<string, string>
    {
        ["custom_field_name_1"] = "custom_field_value_1",
        ["custom_field_name_2"] = "custom_field_value_2",
    },
};
```

