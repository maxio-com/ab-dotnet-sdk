
# List Coupons for Product Family Input

Input structure for the method ListCouponsForProductFamily

## Structure

`ListCouponsForProductFamilyInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductFamilyId` | `int` | Required | The Advanced Billing id of the product family to which the coupon belongs |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 30. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `30`<br><br>**Constraints**: `<= 200` |
| `Filter` | [`ListCouponsFilter`](../../doc/models/list-coupons-filter.md) | Optional | Filter to use for List Coupons operations |
| `CurrencyPrices` | `bool?` | Optional | (Optional) If you have defined multiple currencies at the site level, you can pass `?currency_prices=true` to include an array of currency price data in the response. Use in query `currency_prices=true`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListCouponsForProductFamilyInput listCouponsForProductFamilyInput = new ListCouponsForProductFamilyInput
{
    ProductFamilyId = 140,
    Page = 1,
    PerPage = 50,
    Filter = new ListCouponsFilter
    {
        DateField = BasicDateField.UpdatedAt,
        StartDate = DateTime.Parse("2011-12-17"),
        EndDate = DateTime.Parse("2011-12-15"),
        StartDatetime = DateTime.ParseExact("2011-12-19T09:15:30+00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        EndDatetime = DateTime.ParseExact("2019-06-07T17:20:06Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Ids = new List<int>
        {
            1,
            2,
            3,
        },
        Codes = new List<string>
        {
            "free",
            "free_trial",
        },
    },
    CurrencyPrices = true,
};
```

