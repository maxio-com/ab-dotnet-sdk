
# Create Invoice

## Structure

`CreateInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LineItems` | [`List<CreateInvoiceItem>`](../../doc/models/create-invoice-item.md) | Optional | - |
| `IssueDate` | `DateTime?` | Optional | Date on which the invoice will be issued (format YYYY-MM-DD). This date is interpreted and validated in your site's time zone. It must be today or a date in the past — future dates are not accepted. If omitted, defaults to today in your site's time zone. |
| `NetTerms` | `int?` | Optional | By default, invoices will be created with a due date matching the date of invoice creation. If a different due date is desired, the net_terms parameter can be sent indicating the number of days in advance the due date should be. |
| `PaymentInstructions` | `string` | Optional | - |
| `Memo` | `string` | Optional | A custom memo can be sent to override the site's default. |
| `SellerAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Overrides the defaults for the site. |
| `BillingAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Overrides the default for the customer. |
| `ShippingAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Overrides the default for the customer. |
| `Coupons` | [`List<CreateInvoiceCoupon>`](../../doc/models/create-invoice-coupon.md) | Optional | - |
| `Status` | [`CreateInvoiceStatus?`](../../doc/models/create-invoice-status.md) | Optional | **Default**: `CreateInvoiceStatus.open` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateInvoice createInvoice = new CreateInvoice
{
    LineItems = new List<CreateInvoiceItem>
    {
        new CreateInvoiceItem
        {
            Title = "title4",
            Quantity = CreateInvoiceItemQuantity.FromPrecision(56.68),
            UnitPrice = CreateInvoiceItemUnitPrice.FromPrecision(39.9),
            Taxable = false,
            TaxCode = "tax_code6",
        },
        new CreateInvoiceItem
        {
            Title = "title4",
            Quantity = CreateInvoiceItemQuantity.FromPrecision(56.68),
            UnitPrice = CreateInvoiceItemUnitPrice.FromPrecision(39.9),
            Taxable = false,
            TaxCode = "tax_code6",
        },
    },
    IssueDate = DateTime.Parse("2024-01-01"),
    NetTerms = 202,
    PaymentInstructions = "payment_instructions2",
    Memo = "memo8",
    Status = CreateInvoiceStatus.Draft,
};
```

