
# Update Invoice

Attributes of a draft ad hoc invoice which can be updated. Only the submitted attributes are changed.

## Structure

`UpdateInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LineItems` | [`List<UpdateInvoiceItem>`](../../doc/models/update-invoice-item.md) | Optional | Line item changes to apply. Line items without a `uid` are added, line items with a `uid` are updated, and line items with a `uid` and `_destroy` set to `true` are removed. Existing line items not referenced in the array remain unchanged. |
| `IssueDate` | `DateTime?` | Optional | New issue date for the invoice (format YYYY-MM-DD). This date is interpreted and validated in your site's time zone. It must be today or a date in the past — future dates are not accepted. The due date is recalculated from the issue date and net terms. |
| `NetTerms` | `int?` | Optional | Number of days after the issue date on which the invoice is due. The due date is recalculated when net terms or the issue date change. |
| `PaymentInstructions` | `string` | Optional | Custom payment instructions displayed on the invoice. |
| `Memo` | `string` | Optional | A custom memo displayed on the invoice. |
| `SellerAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Replaces the seller address on the invoice |
| `BillingAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Replaces the billing address on the invoice |
| `ShippingAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Replaces the shipping address on the invoice |
| `Coupons` | [`List<CreateInvoiceCoupon>`](../../doc/models/create-invoice-coupon.md) | Optional | When present, replaces all discounts currently applied to the invoice. Send an empty array to remove all discounts. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

UpdateInvoice updateInvoice = new UpdateInvoice
{
    LineItems = new List<UpdateInvoiceItem>
    {
        new UpdateInvoiceItem
        {
            Title = "title4",
            Quantity = UpdateInvoiceItemQuantity.FromPrecision(56.68),
            UnitPrice = UpdateInvoiceItemUnitPrice.FromPrecision(39.9),
            Taxable = false,
            TaxCode = "tax_code6",
        },
    },
    IssueDate = DateTime.Parse("2024-01-01"),
    NetTerms = 46,
    PaymentInstructions = "payment_instructions6",
    Memo = "memo2",
};
```

