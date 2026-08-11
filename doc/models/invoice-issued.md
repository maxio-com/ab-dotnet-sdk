
# Invoice Issued

## Structure

`InvoiceIssued`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Required | - |
| `Number` | `string` | Required | - |
| `Role` | `string` | Required | - |
| `DueDate` | `DateTime?` | Required | - |
| `IssueDate` | `string` | Required | Invoice issue date. Can be an empty string if value is missing. |
| `PaidDate` | `string` | Required | Paid date. Can be an empty string if value is missing. |
| `DueAmount` | `string` | Required | - |
| `PaidAmount` | `string` | Required | - |
| `TaxAmount` | `string` | Required | - |
| `RefundAmount` | `string` | Required | - |
| `TotalAmount` | `string` | Required | - |
| `StatusAmount` | `string` | Required | - |
| `ProductName` | `string` | Required | - |
| `ConsolidationLevel` | `string` | Required | - |
| `LineItems` | [`List<InvoiceLineItemEventData>`](../../doc/models/invoice-line-item-event-data.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

InvoiceIssued invoiceIssued = new InvoiceIssued
{
    Uid = "uid8",
    Number = "number4",
    Role = "role8",
    DueDate = DateTime.Parse("2016-03-13"),
    IssueDate = "issue_date4",
    PaidDate = "paid_date8",
    DueAmount = "due_amount0",
    PaidAmount = "paid_amount0",
    TaxAmount = "tax_amount8",
    RefundAmount = "refund_amount6",
    TotalAmount = "total_amount4",
    StatusAmount = "status_amount8",
    ProductName = "product_name4",
    ConsolidationLevel = "consolidation_level0",
    LineItems = new List<InvoiceLineItemEventData>
    {
        new InvoiceLineItemEventData
        {
            Uid = "uid8",
            Title = "title4",
            Description = "description8",
            Quantity = 102,
            QuantityDelta = 204,
        },
    },
};
```

