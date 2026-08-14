
# Invoice Previous Balance

## Structure

`InvoicePreviousBalance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CapturedAt` | `DateTimeOffset?` | Optional | - |
| `Invoices` | [`List<InvoiceBalanceItem>`](../../doc/models/invoice-balance-item.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

InvoicePreviousBalance invoicePreviousBalance = new InvoicePreviousBalance
{
    CapturedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Invoices = new List<InvoiceBalanceItem>
    {
        new InvoiceBalanceItem
        {
            Uid = "uid6",
            Number = "number6",
            OutstandingAmount = "outstanding_amount8",
        },
        new InvoiceBalanceItem
        {
            Uid = "uid6",
            Number = "number6",
            OutstandingAmount = "outstanding_amount8",
        },
        new InvoiceBalanceItem
        {
            Uid = "uid6",
            Number = "number6",
            OutstandingAmount = "outstanding_amount8",
        },
    },
};
```

