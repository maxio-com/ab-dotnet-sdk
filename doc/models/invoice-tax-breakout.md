
# Invoice Tax Breakout

## Structure

`InvoiceTaxBreakout`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `TaxableAmount` | `string` | Optional | - |
| `TaxAmount` | `string` | Optional | - |
| `TaxExemptAmount` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceTaxBreakout invoiceTaxBreakout = new InvoiceTaxBreakout
{
    Uid = "uid4",
    TaxableAmount = "taxable_amount8",
    TaxAmount = "tax_amount2",
    TaxExemptAmount = "tax_exempt_amount4",
};
```

