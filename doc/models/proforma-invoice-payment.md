
# Proforma Invoice Payment

## Structure

`ProformaInvoicePayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Memo` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `OriginalAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `AppliedAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Prepayment` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProformaInvoicePayment proformaInvoicePayment = new ProformaInvoicePayment
{
    Memo = "memo2",
    OriginalAmount = "original_amount2",
    AppliedAmount = "applied_amount0",
    Prepayment = false,
};
```

