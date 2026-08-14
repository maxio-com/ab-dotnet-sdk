
# List Events Input

Input structure for the method ListEvents

## Structure

`ListEventsInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `SinceId` | `long?` | Optional | Returns events with an id greater than or equal to the one specified. |
| `MaxId` | `long?` | Optional | Returns events with an id less than or equal to the one specified. |
| `Direction` | [`Direction?`](../../doc/models/direction.md) | Optional | The sort direction of the returned events.<br><br>**Default**: `Direction.desc` |
| `Filter` | [`List<EventKey>`](../../doc/models/event-key.md) | Optional | You can pass multiple event keys after comma.<br>Use in query `filter=signup_success,payment_success`. |
| `DateField` | [`ListEventsDateField?`](../../doc/models/list-events-date-field.md) | Optional | The type of filter you would like to apply to your search. |
| `StartDate` | `string` | Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `EndDate` | `string` | Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `StartDatetime` | `string` | Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |
| `EndDatetime` | `string` | Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListEventsInput listEventsInput = new ListEventsInput
{
    Page = 1,
    PerPage = 50,
    SinceId = 104L,
    MaxId = 0L,
    Direction = Direction.Desc,
    Filter = new List<EventKey>
    {
        EventKey.CustomFieldValueChange,
        EventKey.PaymentSuccess,
    },
    DateField = ListEventsDateField.CreatedAt,
    StartDate = "start_date6",
    EndDate = "end_date0",
    StartDatetime = "start_datetime0",
    EndDatetime = "end_datetime8",
};
```

