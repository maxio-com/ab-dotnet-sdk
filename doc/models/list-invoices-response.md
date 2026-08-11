
# List Invoices Response

## Structure

`ListInvoicesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Invoices` | [`List<Invoice>`](../../doc/models/invoice.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListInvoicesResponse listInvoicesResponse = new ListInvoicesResponse
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
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
    },
};
```

