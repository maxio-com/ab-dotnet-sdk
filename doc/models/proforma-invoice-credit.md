
# Proforma Invoice Credit

## Structure

`ProformaInvoiceCredit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Memo` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `OriginalAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `AppliedAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProformaInvoiceCredit proformaInvoiceCredit = new ProformaInvoiceCredit
{
    Uid = "uid4",
    Memo = "memo8",
    OriginalAmount = "original_amount8",
    AppliedAmount = "applied_amount4",
};
```

