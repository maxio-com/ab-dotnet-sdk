
# Invoice Discount

## Structure

`InvoiceDiscount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Title` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Code` | `string` | Optional | - |
| `SourceType` | [`InvoiceDiscountSourceType?`](../../doc/models/invoice-discount-source-type.md) | Optional | - |
| `SourceId` | `int?` | Optional | - |
| `DiscountType` | [`InvoiceDiscountType?`](../../doc/models/invoice-discount-type.md) | Optional | - |
| `Percentage` | `string` | Optional | - |
| `EligibleAmount` | `string` | Optional | - |
| `DiscountAmount` | `string` | Optional | - |
| `TransactionId` | `int?` | Optional | - |
| `LineItemBreakouts` | [`List<InvoiceDiscountBreakout>`](../../doc/models/invoice-discount-breakout.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceDiscount invoiceDiscount = new InvoiceDiscount
{
    Uid = "uid4",
    Title = "title0",
    Description = "description6",
    Code = "code2",
    SourceType = InvoiceDiscountSourceType.Coupon,
};
```

