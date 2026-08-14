
# Proforma Invoice Tax

## Structure

`ProformaInvoiceTax`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Title` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `SourceType` | [`ProformaInvoiceTaxSourceType?`](../../doc/models/proforma-invoice-tax-source-type.md) | Optional | - |
| `Percentage` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `TaxableAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `TaxAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `LineItemBreakouts` | [`List<InvoiceTaxBreakout>`](../../doc/models/invoice-tax-breakout.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProformaInvoiceTax proformaInvoiceTax = new ProformaInvoiceTax
{
    Uid = "uid4",
    Title = "title0",
    SourceType = ProformaInvoiceTaxSourceType.Tax,
    Percentage = "percentage2",
    TaxableAmount = "taxable_amount8",
};
```

