
# List Prepayments Input

Input structure for the method ListPrepayments

## Structure

`ListPrepaymentsInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int` | Required | The Chargify id of the subscription. |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `Filter` | [`ListPrepaymentsFilter`](../../doc/models/list-prepayments-filter.md) | Optional | Filter to use for List Prepayments operations |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListPrepaymentsInput listPrepaymentsInput = new ListPrepaymentsInput
{
    SubscriptionId = 222,
    Page = 1,
    PerPage = 50,
    Filter = new ListPrepaymentsFilter
    {
        DateField = ListPrepaymentDateField.CreatedAt,
        StartDate = DateTime.Parse("2024-01-01"),
        EndDate = DateTime.Parse("2024-01-31"),
    },
};
```

