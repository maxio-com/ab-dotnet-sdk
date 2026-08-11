
# Customer

## Structure

`Customer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | The first name of the customer |
| `LastName` | `string` | Optional | The last name of the customer |
| `Email` | `string` | Optional | The email address of the customer |
| `CcEmails` | `string` | Optional | “A comma-separated list of emails that should be cc’d on all customer communications (e.g., “joe@example.com, sue@example.com”)” |
| `Organization` | `string` | Optional | The organization of the customer. If no value, `null` or empty string is provided, `organization` will be populated with the customer's first and last name, separated with a space. |
| `Reference` | `string` | Optional | The unique identifier used within your own application for this customer |
| `Id` | `int?` | Optional | The customer ID in Chargify |
| `CreatedAt` | `DateTimeOffset?` | Optional | The timestamp in which the customer object was created in Chargify |
| `UpdatedAt` | `DateTimeOffset?` | Optional | The timestamp in which the customer object was last edited |
| `Address` | `string` | Optional | The customer’s shipping street address (e.g., “123 Main St.”) |
| `Address2` | `string` | Optional | Second line of the customer’s shipping address e.g., “Apt. 100” |
| `City` | `string` | Optional | The customer’s shipping address city (e.g., “Boston”) |
| `State` | `string` | Optional | The customer’s shipping address state (e.g., “MA”) |
| `StateName` | `string` | Optional | The customer's full name of state |
| `Zip` | `string` | Optional | The customer’s shipping address zip code (e.g., “12345”) |
| `Country` | `string` | Optional | The customer shipping address country |
| `CountryName` | `string` | Optional | The customer's full name of country |
| `Phone` | `string` | Optional | The phone number of the customer |
| `Verified` | `bool?` | Optional | Is the customer verified to use ACH as a payment method. |
| `PortalCustomerCreatedAt` | `DateTimeOffset?` | Optional | The timestamp of when the Billing Portal entry was created at for the customer |
| `PortalInviteLastSentAt` | `DateTimeOffset?` | Optional | The timestamp of when the Billing Portal invite was last sent at |
| `PortalInviteLastAcceptedAt` | `DateTimeOffset?` | Optional | The timestamp of when the Billing Portal invite was last accepted |
| `TaxExempt` | `bool?` | Optional | The tax exempt status for the customer. Acceptable values are true or 1 for true and false or 0 for false. |
| `Surcharging` | `bool?` | Optional | Whether surcharging is enabled for the customer. Only included on sites where surcharging control is enabled. |
| `VatNumber` | `string` | Optional | The VAT business identification number for the customer. This number is used to determine VAT tax opt out rules. It is not validated when added or updated on a customer record. Instead, it is validated via VIES before calculating taxes. Only valid business identification numbers will allow for VAT opt out. |
| `ParentId` | `int?` | Optional | The parent ID in Chargify if applicable. Parent is another Customer object. |
| `Locale` | `string` | Optional | The locale for the customer to identify language-region |
| `DefaultSubscriptionGroupUid` | `string` | Optional | - |
| `SalesforceId` | `string` | Optional | The Salesforce ID for the customer |
| `TaxExemptReason` | `string` | Optional | The Tax Exemption Reason Code for the customer |
| `DefaultAutoRenewalProfileId` | `int?` | Optional | The default auto-renewal profile ID for the customer |
| `Maxioid` | `string` | Optional | The Maxio-generated unique identifier for the customer. |
| `BrandingThemeId` | `int?` | Optional | The ID of the Branding Theme assigned to this customer as the customer's default Branding Theme. This customer-level Branding Theme is used when a subscription does not have its own subscription-level Branding Theme.  Available only when Branding Themes are enabled for the site. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Customer customer = new Customer
{
    FirstName = "first_name0",
    LastName = "last_name8",
    Email = "email6",
    CcEmails = "cc_emails0",
    Organization = "organization6",
};
```

