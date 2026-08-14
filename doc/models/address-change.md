
# Address Change

## Structure

`AddressChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Before` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Required | - |
| `After` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AddressChange addressChange = new AddressChange
{
    Before = new InvoiceAddress
    {
        Street = "street0",
        Line2 = "line24",
        City = "city0",
        State = "state6",
        Zip = "zip4",
    },
    After = new InvoiceAddress
    {
        Street = "street2",
        Line2 = "line26",
        City = "city8",
        State = "state2",
        Zip = "zip4",
    },
};
```

