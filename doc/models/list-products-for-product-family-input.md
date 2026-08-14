
# List Products for Product Family Input

Input structure for the method ListProductsForProductFamily

## Structure

`ListProductsForProductFamilyInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductFamilyId` | `string` | Required | Either the product family's id or its handle prefixed with `handle:` |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `DateField` | [`BasicDateField?`](../../doc/models/basic-date-field.md) | Optional | The type of filter you would like to apply to your search.<br>Use in query: `date_field=created_at`. |
| `Filter` | [`ListProductsFilter`](../../doc/models/list-products-filter.md) | Optional | Filter to use for List Products operations |
| `StartDate` | `DateTime?` | Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns products with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `EndDate` | `DateTime?` | Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns products with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `StartDatetime` | `DateTimeOffset?` | Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns products with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |
| `EndDatetime` | `DateTimeOffset?` | Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns products with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. |
| `IncludeArchived` | `bool?` | Optional | Include archived products. |
| `Include` | [`ListProductsInclude?`](../../doc/models/list-products-include.md) | Optional | Allows including additional data in the response. Use in query `include=prepaid_product_price_point`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListProductsForProductFamilyInput listProductsForProductFamilyInput = new ListProductsForProductFamilyInput
{
    ProductFamilyId = "product_family_id4",
    Page = 1,
    PerPage = 50,
    DateField = BasicDateField.UpdatedAt,
    Filter = new ListProductsFilter
    {
        Ids = new List<int>
        {
            1,
            2,
            3,
        },
        PrepaidProductPricePoint = new PrepaidProductPricePointFilter
        {
            ProductPricePointId = "product_price_point_id2",
        },
        UseSiteExchangeRate = false,
    },
    StartDate = DateTime.Parse("2016-03-13"),
    EndDate = DateTime.Parse("2016-03-13"),
    StartDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDatetime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    IncludeArchived = false,
    Include = ListProductsInclude.PrepaidProductPricePoint,
};
```

