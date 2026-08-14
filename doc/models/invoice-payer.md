
# Invoice Payer

## Structure

`InvoicePayer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargifyId` | `int?` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `Organization` | `string` | Optional | - |
| `Email` | `string` | Optional | - |
| `VatNumber` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoicePayer invoicePayer = new InvoicePayer
{
    ChargifyId = 198,
    FirstName = "first_name2",
    LastName = "last_name0",
    Organization = "organization4",
    Email = "email4",
};
```

