
# Invoice Customer

Information about the customer who is owner or recipient of the invoiced subscription.

## Structure

`InvoiceCustomer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargifyId` | `int?` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Organization` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `VatNumber` | `string` | Optional | - |
| `Reference` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceCustomer invoiceCustomer = new InvoiceCustomer
{
    ChargifyId = 82,
    FirstName = "first_name2",
    LastName = "last_name0",
    Organization = "organization6",
    Email = "email4",
};
```

