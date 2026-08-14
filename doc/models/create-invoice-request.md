
# Create Invoice Request

## Structure

`CreateInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Invoice` | [`CreateInvoice`](../../doc/models/create-invoice.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateInvoiceRequest createInvoiceRequest = new CreateInvoiceRequest
{
    Invoice = new CreateInvoice
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
        NetTerms = 144,
        PaymentInstructions = "payment_instructions6",
        Memo = "memo0",
        Status = CreateInvoiceStatus.Draft,
    },
};
```

