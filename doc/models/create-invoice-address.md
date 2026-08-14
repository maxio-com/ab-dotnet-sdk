
# Create Invoice Address

Overrides the default address.

## Structure

`CreateInvoiceAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Phone` | `string` | Optional | - |
| `Address` | `string` | Optional | - |
| `Address2` | `string` | Optional | - |
| `City` | `string` | Optional | - |
| `State` | `string` | Optional | - |
| `Zip` | `string` | Optional | - |
| `Country` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateInvoiceAddress createInvoiceAddress = new CreateInvoiceAddress
{
    FirstName = "first_name6",
    LastName = "last_name4",
    Phone = "phone4",
    Address = "address2",
    Address2 = "address_20",
};
```

