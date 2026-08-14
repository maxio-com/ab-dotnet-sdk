
# Invoice Address

## Structure

`InvoiceAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Street` | `string` | Optional | - |
| `Line2` | `string` | Optional | - |
| `City` | `string` | Optional | - |
| `State` | `string` | Optional | - |
| `Zip` | `string` | Optional | - |
| `Country` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceAddress invoiceAddress = new InvoiceAddress
{
    Street = "street2",
    Line2 = "line26",
    City = "city2",
    State = "state8",
    Zip = "zip6",
};
```

