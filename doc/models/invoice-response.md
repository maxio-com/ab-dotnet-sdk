
# Invoice Response

## Structure

`InvoiceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceResponse invoiceResponse = new InvoiceResponse
{
    Invoice = new Invoice
    {
        Id = 166L,
        Uid = "uid6",
        SiteId = 92,
        CustomerId = 204,
        SubscriptionId = 20,
        IssueDate = DateTime.Parse("2024-01-01"),
        DueDate = DateTime.Parse("2024-01-01"),
        PaidDate = DateTime.Parse("2024-01-01"),
        PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
    },
};
```

