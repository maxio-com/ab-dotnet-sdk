
# Proforma Invoice Discount

## Structure

`ProformaInvoiceDiscount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Title` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Code` | `string` | Optional | - |
| `SourceType` | [`ProformaInvoiceDiscountSourceType?`](../../doc/models/proforma-invoice-discount-source-type.md) | Optional | - |
| `DiscountType` | [`InvoiceDiscountType?`](../../doc/models/invoice-discount-type.md) | Optional | - |
| `EligibleAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `DiscountAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `LineItemBreakouts` | [`List<InvoiceDiscountBreakout>`](../../doc/models/invoice-discount-breakout.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ProformaInvoiceDiscount proformaInvoiceDiscount = new ProformaInvoiceDiscount
{
    Uid = "uid2",
    Title = "title8",
    Code = "code0",
    SourceType = ProformaInvoiceDiscountSourceType.Coupon,
    DiscountType = InvoiceDiscountType.Percentage,
};
```

