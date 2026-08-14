
# Update Customer

## Structure

`UpdateCustomer`

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
| `Locale` | `string` | Optional | Set a specific language on a customer record. |
| `VatNumber` | `string` | Optional | - |
| `TaxExempt` | `bool?` | Optional | - |
| `Surcharging` | `bool?` | Optional | Whether surcharging is enabled for the customer. Only applied on sites where surcharging control is enabled. |
| `TaxExemptReason` | `string` | Optional | - |
| `ParentId` | `int?` | Optional | - |
| `Verified` | `bool?` | Optional | Is the customer verified to use ACH as a payment method. Available only on the Authorize.Net gateway. |
| `SalesforceId` | `string` | Optional | The Salesforce ID of the customer |
| `BrandingThemeId` | `int?` | Optional | The ID of the Branding Theme assigned to this customer as the customer's default Branding Theme. This customer-level Branding Theme is used when a subscription does not have its own subscription-level Branding Theme. Available only when Branding Themes are enabled for the site. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateCustomer updateCustomer = new UpdateCustomer
{
    FirstName = "first_name2",
    LastName = "last_name0",
    Email = "email4",
    CcEmails = "cc_emails8",
    Organization = "organization6",
};
```

