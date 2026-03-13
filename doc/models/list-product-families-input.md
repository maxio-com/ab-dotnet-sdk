
# List Product Families Input

Input structure for the method ListProductFamilies

## Structure

`ListProductFamiliesInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateField` | [`BasicDateField?`](../../doc/models/basic-date-field.md) | Optional | The type of filter you would like to apply to your search.<br>Use in query: `date_field=created_at`. |
| `StartDate` | `DateTime?` | Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns products with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `EndDate` | `DateTime?` | Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns products with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `StartDatetime` | `DateTimeOffset?` | Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns products with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |
| `EndDatetime` | `DateTimeOffset?` | Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns products with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

ListProductFamiliesInput listProductFamiliesInput = new ListProductFamiliesInput
{
    DateField = BasicDateField.UpdatedAt,
    StartDate = DateTime.Parse("2016-03-13"),
    EndDate = DateTime.Parse("2016-03-13"),
    StartDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

