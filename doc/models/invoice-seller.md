
# Invoice Seller

Information about the seller (merchant) listed on the masthead of the invoice.

## Structure

`InvoiceSeller`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Address` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Optional | - |
| `Phone` | `string` | Optional | - |
| `LogoUrl` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceSeller invoiceSeller = new InvoiceSeller
{
    Name = "name4",
    Address = new InvoiceAddress
    {
        Street = "street6",
        Line2 = "line20",
        City = "city6",
        State = "state2",
        Zip = "zip0",
    },
    Phone = "phone6",
    LogoUrl = "logo_url6",
};
```

