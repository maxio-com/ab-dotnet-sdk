
# List Proforma Invoices Input

Input structure for the method ListProformaInvoices

## Structure

`ListProformaInvoicesInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int` | Required | The Chargify id of the subscription. |
| `StartDate` | `string` | Optional | The beginning date range for the invoice's Due Date, in the YYYY-MM-DD format. |
| `EndDate` | `string` | Optional | The ending date range for the invoice's Due Date, in the YYYY-MM-DD format. |
| `Status` | [`ProformaInvoiceStatus?`](../../doc/models/proforma-invoice-status.md) | Optional | The current status of the invoice.  Allowed Values: draft, open, paid, pending, voided |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `Direction` | [`Direction?`](../../doc/models/direction.md) | Optional | The sort direction of the returned invoices.<br><br>**Default**: `Direction.desc` |
| `LineItems` | `bool?` | Optional | Include line items data.<br><br>**Default**: `false` |
| `Discounts` | `bool?` | Optional | Include discounts data.<br><br>**Default**: `false` |
| `Taxes` | `bool?` | Optional | Include taxes data.<br><br>**Default**: `false` |
| `Credits` | `bool?` | Optional | Include credits data.<br><br>**Default**: `false` |
| `Payments` | `bool?` | Optional | Include payments data.<br><br>**Default**: `false` |
| `CustomFields` | `bool?` | Optional | Include custom fields data.<br><br>**Default**: `false` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListProformaInvoicesInput listProformaInvoicesInput = new ListProformaInvoicesInput
{
    SubscriptionId = 222,
    StartDate = "start_date6",
    EndDate = "end_date0",
    Status = ProformaInvoiceStatus.Archived,
    Page = 1,
    PerPage = 50,
    Direction = Direction.Desc,
    LineItems = false,
    Discounts = false,
    Taxes = false,
    Credits = false,
    Payments = false,
    CustomFields = false,
};
```

