
# Update Invoice Request

Request payload for updating a draft ad hoc invoice.

## Structure

`UpdateInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Invoice` | [`UpdateInvoice`](../../doc/models/update-invoice.md) | Required | Attributes of a draft ad hoc invoice which can be updated. Only the submitted attributes are changed. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

UpdateInvoiceRequest updateInvoiceRequest = new UpdateInvoiceRequest
{
    Invoice = new UpdateInvoice
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
            new UpdateInvoiceItem
            {
                Title = "title4",
                Quantity = UpdateInvoiceItemQuantity.FromPrecision(56.68),
                UnitPrice = UpdateInvoiceItemUnitPrice.FromPrecision(39.9),
                Taxable = false,
                TaxCode = "tax_code6",
            },
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
        NetTerms = 144,
        PaymentInstructions = "payment_instructions6",
        Memo = "memo0",
    },
};
```

