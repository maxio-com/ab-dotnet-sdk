
# List Components for Product Family Input

Input structure for the method ListComponentsForProductFamily

## Structure

`ListComponentsForProductFamilyInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductFamilyId` | `int` | Required | The Advanced Billing id of the product family |
| `IncludeArchived` | `bool?` | Optional | Include archived items. |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `Filter` | [`ListComponentsFilter`](../../doc/models/list-components-filter.md) | Optional | Filter to use for List Components operations |
| `DateField` | [`BasicDateField?`](../../doc/models/basic-date-field.md) | Optional | The type of filter you would like to apply to your search. Use in query `date_field=created_at`. |
| `EndDate` | `string` | Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `EndDatetime` | `string` | Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. optional. |
| `StartDate` | `string` | Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `StartDatetime` | `string` | Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListComponentsForProductFamilyInput listComponentsForProductFamilyInput = new ListComponentsForProductFamilyInput
{
    ProductFamilyId = 140,
    IncludeArchived = false,
    Page = 1,
    PerPage = 50,
    Filter = new ListComponentsFilter
    {
        Ids = new List<int>
        {
            1,
            2,
            3,
        },
        UseSiteExchangeRate = false,
    },
    DateField = BasicDateField.UpdatedAt,
    EndDate = "end_date0",
    EndDatetime = "end_datetime8",
    StartDate = "start_date6",
    StartDatetime = "start_datetime0",
};
```

