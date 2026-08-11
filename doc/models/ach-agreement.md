
# ACH Agreement

(Optional) If passed, the proof of the authorized ACH agreement terms will be persisted.

## Structure

`ACHAgreement`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AgreementTerms` | `string` | Optional | (Required when providing ACH agreement params) The ACH authorization agreement terms. |
| `AuthorizerFirstName` | `string` | Optional | (Required when providing ACH agreement params) The first name of the person authorizing the ACH agreement. |
| `AuthorizerLastName` | `string` | Optional | (Required when providing ACH agreement params) The last name of the person authorizing the ACH agreement. |
| `IpAddress` | `string` | Optional | (Required when providing ACH agreement params) The IP address of the person authorizing the ACH agreement. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ACHAgreement aCHAgreement = new ACHAgreement
{
    AgreementTerms = "agreement_terms4",
    AuthorizerFirstName = "authorizer_first_name2",
    AuthorizerLastName = "authorizer_last_name2",
    IpAddress = "ip_address2",
};
```

