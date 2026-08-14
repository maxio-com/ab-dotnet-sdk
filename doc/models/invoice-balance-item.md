
# Invoice Balance Item

## Structure

`InvoiceBalanceItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `OutstandingAmount` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceBalanceItem invoiceBalanceItem = new InvoiceBalanceItem
{
    Uid = "uid8",
    Number = "number6",
    OutstandingAmount = "outstanding_amount6",
};
```

