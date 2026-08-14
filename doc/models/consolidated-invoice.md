
# Consolidated Invoice

## Structure

`ConsolidatedInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Invoices` | [`List<Invoice>`](../../doc/models/invoice.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ConsolidatedInvoice consolidatedInvoice = new ConsolidatedInvoice
{
    Invoices = new List<Invoice>
    {
        new Invoice
        {
            Id = 196L,
            Uid = "uid6",
            SiteId = 122,
            CustomerId = 234,
            SubscriptionId = 50,
        },
        new Invoice
        {
            Id = 196L,
            Uid = "uid6",
            SiteId = 122,
            CustomerId = 234,
            SubscriptionId = 50,
        },
        new Invoice
        {
            Id = 196L,
            Uid = "uid6",
            SiteId = 122,
            CustomerId = 234,
            SubscriptionId = 50,
        },
    },
};
```

