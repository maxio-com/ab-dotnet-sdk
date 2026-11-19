
# Invoice Tax

## Structure

`InvoiceTax`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Title` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `SourceType` | [`ProformaInvoiceTaxSourceType?`](../../doc/models/proforma-invoice-tax-source-type.md) | Optional | The source of the tax. `Tax` is a tax configured in Advanced Billing. The other values identify the tax service that calculated the tax. |
| `SourceId` | `int?` | Optional | - |
| `Percentage` | `string` | Optional | - |
| `TaxableAmount` | `string` | Optional | - |
| `TaxAmount` | `string` | Optional | - |
| `TransactionId` | `int?` | Optional | - |
| `LineItemBreakouts` | [`List<InvoiceTaxBreakout>`](../../doc/models/invoice-tax-breakout.md) | Optional | - |
| `TaxComponentBreakouts` | [`List<InvoiceTaxComponentBreakout>`](../../doc/models/invoice-tax-component-breakout.md) | Optional | - |
| `EuVat` | `bool?` | Optional | - |
| `Type` | `string` | Optional | - |
| `TaxExemptAmount` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceTax invoiceTax = new InvoiceTax
{
    Uid = "uid2",
    Title = "title8",
    Description = "description2",
    SourceType = ProformaInvoiceTaxSourceType.TaxJar,
    SourceId = 86,
};
```

