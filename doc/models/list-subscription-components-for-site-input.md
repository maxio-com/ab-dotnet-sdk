
# List Subscription Components for Site Input

Input structure for the method ListSubscriptionComponentsForSite

## Structure

`ListSubscriptionComponentsForSiteInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `Sort` | [`ListSubscriptionComponentsSort?`](../../doc/models/list-subscription-components-sort.md) | Optional | The attribute by which to sort. Use in query: `sort=updated_at`. |
| `Direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |
| `Filter` | [`ListSubscriptionComponentsForSiteFilter`](../../doc/models/list-subscription-components-for-site-filter.md) | Optional | Filter to use for List Subscription Components For Site operation |
| `DateField` | [`SubscriptionListDateField?`](../../doc/models/subscription-list-date-field.md) | Optional | The type of filter you'd like to apply to your search. Use in query: `date_field=updated_at`. |
| `StartDate` | `string` | Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. Use in query `start_date=2011-12-15`. |
| `StartDatetime` | `string` | Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of start_date. Use in query `start_datetime=2022-07-01 09:00:05`. |
| `EndDate` | `string` | Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. Use in query `end_date=2011-12-16`. |
| `EndDatetime` | `string` | Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of end_date. Use in query `end_datetime=2022-07-01 09:00:05`. |
| `SubscriptionIds` | `List<int>` | Optional | Allows fetching components allocation with matching subscription id based on provided ids. Use in query `subscription_ids=1,2,3`.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `200` |
| `PricePointIds` | [`IncludeNotNull?`](../../doc/models/include-not-null.md) | Optional | Allows fetching components allocation only if price point id is present. Use in query `price_point_ids=not_null`. |
| `ProductFamilyIds` | `List<int>` | Optional | Allows fetching components allocation with matching product family id based on provided ids. Use in query `product_family_ids=1,2,3`. |
| `Include` | [`ListSubscriptionComponentsInclude?`](../../doc/models/list-subscription-components-include.md) | Optional | Allows including additional data in the response. Use in query `include=subscription,historic_usages`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListSubscriptionComponentsForSiteInput listSubscriptionComponentsForSiteInput = new ListSubscriptionComponentsForSiteInput
{
    Page = 1,
    PerPage = 50,
    Sort = ListSubscriptionComponentsSort.UpdatedAt,
    Direction = SortingDirection.Asc,
    Filter = new ListSubscriptionComponentsForSiteFilter
    {
        Currencies = new List<string>
        {
            "EUR",
            "USD",
        },
        UseSiteExchangeRate = false,
        Subscription = new SubscriptionFilter
        {
            States = new List<SubscriptionStateFilter>
            {
                SubscriptionStateFilter.Trialing,
                SubscriptionStateFilter.Unpaid,
                SubscriptionStateFilter.Active,
            },
            DateField = SubscriptionListDateField.UpdatedAt,
            StartDate = DateTime.Parse("2016-03-13"),
            EndDate = DateTime.Parse("2016-03-13"),
            StartDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    },
    DateField = SubscriptionListDateField.UpdatedAt,
    StartDate = "start_date6",
    StartDatetime = "start_datetime0",
    EndDate = "end_date0",
    EndDatetime = "end_datetime8",
    SubscriptionIds = new List<int>
    {
        1,
        2,
        3,
    },
    PricePointIds = IncludeNotNull.NotNull,
    ProductFamilyIds = new List<int>
    {
        1,
        2,
        3,
    },
    Include = ListSubscriptionComponentsInclude.Subscription,
};
```

