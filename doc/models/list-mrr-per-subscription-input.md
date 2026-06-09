
# List Mrr per Subscription Input

Input structure for the method ListMrrPerSubscription

## Structure

`ListMrrPerSubscriptionInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filter` | [`ListMrrFilter`](../../doc/models/list-mrr-filter.md) | Optional | Filter to use for List MRR per subscription operation |
| `AtTime` | `string` | Optional | Submit a timestamp in ISO8601 format to request MRR for a historic time. Use in query: `at_time=2022-01-10T10:00:00-05:00`. |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `Direction` | [`Direction?`](../../doc/models/direction.md) | Optional | Controls the order in which results are returned. Records are ordered by subscription_id in ascending order by default. Use in query `direction=desc`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListMrrPerSubscriptionInput listMrrPerSubscriptionInput = new ListMrrPerSubscriptionInput
{
    Filter = new ListMrrFilter
    {
        SubscriptionIds = new List<int>
        {
            1,
            2,
            3,
        },
    },
    AtTime = "at_time=2022-01-10T10:00:00-05:00",
    Page = 1,
    PerPage = 50,
    Direction = Direction.Desc,
};
```

