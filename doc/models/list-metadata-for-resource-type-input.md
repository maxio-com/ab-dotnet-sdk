
# List Metadata for Resource Type Input

Input structure for the method ListMetadataForResourceType

## Structure

`ListMetadataForResourceTypeInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | [`ResourceType`](../../doc/models/resource-type.md) | Required | The resource type to which the metafields belong. |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `DateField` | [`BasicDateField?`](../../doc/models/basic-date-field.md) | Optional | The type of filter you would like to apply to your search. |
| `StartDate` | `DateTime?` | Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns metadata with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `EndDate` | `DateTime?` | Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns metadata with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `StartDatetime` | `DateTimeOffset?` | Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns metadata with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |
| `EndDatetime` | `DateTimeOffset?` | Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns metadata with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. |
| `WithDeleted` | `bool?` | Optional | Allow to fetch deleted metadata. |
| `ResourceIds` | `List<int>` | Optional | Allow to fetch metadata for multiple records based on provided ids. Use in query: `resource_ids[]=122&resource_ids[]=123&resource_ids[]=124`.<br><br>**Constraints**: *Maximum Items*: `50` |
| `Direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListMetadataForResourceTypeInput listMetadataForResourceTypeInput = new ListMetadataForResourceTypeInput
{
    ResourceType = ResourceType.Subscriptions,
    Page = 1,
    PerPage = 50,
    DateField = BasicDateField.UpdatedAt,
    StartDate = DateTime.Parse("2016-03-13"),
    EndDate = DateTime.Parse("2016-03-13"),
    StartDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    WithDeleted = false,
    ResourceIds = new List<int>
    {
        198,
        199,
    },
    Direction = SortingDirection.Asc,
};
```

