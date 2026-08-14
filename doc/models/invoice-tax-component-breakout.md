
# Invoice Tax Component Breakout

## Structure

`InvoiceTaxComponentBreakout`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TaxRuleId` | `int?` | Optional | - |
| `Percentage` | `string` | Optional | - |
| `CountryCode` | `string` | Optional | - |
| `SubdivisionCode` | `string` | Optional | - |
| `TaxAmount` | `string` | Optional | - |
| `TaxableAmount` | `string` | Optional | - |
| `TaxExemptAmount` | `string` | Optional | - |
| `NonTaxableAmount` | `string` | Optional | - |
| `TaxName` | `string` | Optional | - |
| `TaxType` | `string` | Optional | - |
| `RateType` | `string` | Optional | - |
| `TaxAuthorityType` | `int?` | Optional | - |
| `StateAssignedNo` | `string` | Optional | - |
| `TaxSubType` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceTaxComponentBreakout invoiceTaxComponentBreakout = new InvoiceTaxComponentBreakout
{
    TaxRuleId = 66,
    Percentage = "percentage0",
    CountryCode = "country_code2",
    SubdivisionCode = "subdivision_code6",
    TaxAmount = "tax_amount4",
};
```

