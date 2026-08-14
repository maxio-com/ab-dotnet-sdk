
# Proforma Invoice Issued

## Structure

`ProformaInvoiceIssued`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Required | - |
| `Number` | `string` | Required | - |
| `Role` | `string` | Required | - |
| `DeliveryDate` | `DateTime` | Required | - |
| `CreatedAt` | `DateTimeOffset` | Required | - |
| `DueAmount` | `string` | Required | - |
| `PaidAmount` | `string` | Required | - |
| `TaxAmount` | `string` | Required | - |
| `TotalAmount` | `string` | Required | - |
| `ProductName` | `string` | Required | - |
| `LineItems` | [`List<InvoiceLineItemEventData>`](../../doc/models/invoice-line-item-event-data.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ProformaInvoiceIssued proformaInvoiceIssued = new ProformaInvoiceIssued
{
    Uid = "uid6",
    Number = "number4",
    Role = "role0",
    DeliveryDate = DateTime.Parse("2016-03-13"),
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DueAmount = "due_amount8",
    PaidAmount = "paid_amount8",
    TaxAmount = "tax_amount0",
    TotalAmount = "total_amount2",
    ProductName = "product_name2",
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

