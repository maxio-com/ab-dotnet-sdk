
# List Proforma Invoices Response

## Structure

`ListProformaInvoicesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProformaInvoices` | [`List<ProformaInvoice>`](../../doc/models/proforma-invoice.md) | Optional | - |
| `Meta` | [`ListProformaInvoicesMeta`](../../doc/models/list-proforma-invoices-meta.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListProformaInvoicesResponse listProformaInvoicesResponse = new ListProformaInvoicesResponse
{
    ProformaInvoices = new List<ProformaInvoice>
    {
        new ProformaInvoice
        {
            Uid = "uid0",
            SiteId = 140,
            CustomerId = 252,
            SubscriptionId = 68,
            Number = 56,
        },
        new ProformaInvoice
        {
            Uid = "uid0",
            SiteId = 140,
            CustomerId = 252,
            SubscriptionId = 68,
            Number = 56,
        },
        new ProformaInvoice
        {
            Uid = "uid0",
            SiteId = 140,
            CustomerId = 252,
            SubscriptionId = 68,
            Number = 56,
        },
    },
    Meta = new ListProformaInvoicesMeta
    {
        TotalCount = 150,
        CurrentPage = 126,
        TotalPages = 138,
        StatusCode = 168,
    },
};
```

