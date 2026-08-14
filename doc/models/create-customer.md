
# Create Customer

## Structure

`CreateCustomer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Required | - |
| `LastName` | `string` | Required | - |
| `Email` | `string` | Required | - |
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
| `Locale` | `string` | Optional | Set a specific language on a customer record. |
| `VatNumber` | `string` | Optional | - |
| `TaxExempt` | `bool?` | Optional | - |
| `Surcharging` | `bool?` | Optional | Whether surcharging is enabled for the customer. Defaults to `true` when omitted. Only applied on sites where surcharging control is enabled. |
| `TaxExemptReason` | `string` | Optional | - |
| `ParentId` | `int?` | Optional | The parent ID in Chargify if applicable. Parent is another Customer object. |
| `SalesforceId` | `string` | Optional | The Salesforce ID of the customer |
| `BrandingThemeId` | `int?` | Optional | The ID of the Branding Theme assigned to this customer as the customer's default Branding Theme. This customer-level Branding Theme is used when a subscription does not have its own subscription-level Branding Theme. Available only when Branding Themes are enabled for the site. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateCustomer createCustomer = new CreateCustomer
{
    FirstName = "first_name0",
    LastName = "last_name8",
    Email = "email6",
    CcEmails = "cc_emails0",
    Organization = "organization6",
    Reference = "reference4",
    Address = "address6",
    Address2 = "address_24",
};
```

