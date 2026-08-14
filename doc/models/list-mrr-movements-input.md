
# List Mrr Movements Input

Input structure for the method ListMrrMovements

## Structure

`ListMrrMovementsInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int?` | Optional | (Optional) Filter results by subscription. |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 10. The maximum allowed values is 50; any per_page value over 50 will be changed to 50.<br>Use in query `per_page=20`.<br><br>**Default**: `10`<br><br>**Constraints**: `<= 50` |
| `Direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListMrrMovementsInput listMrrMovementsInput = new ListMrrMovementsInput
{
    SubscriptionId = 222,
    Page = 1,
    PerPage = 20,
    Direction = SortingDirection.Asc,
};
```

