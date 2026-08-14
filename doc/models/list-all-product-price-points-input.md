
# List All Product Price Points Input

Input structure for the method ListAllProductPricePoints

## Structure

`ListAllProductPricePointsInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |
| `Filter` | [`ListPricePointsFilter`](../../doc/models/list-price-points-filter.md) | Optional | Filter to use for List PricePoints operations |
| `Include` | [`ListProductsPricePointsInclude?`](../../doc/models/list-products-price-points-include.md) | Optional | Allows including additional data in the response. Use in query: `include=currency_prices`. |
| `Page` | `int?` | Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `PerPage` | `int?` | Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListAllProductPricePointsInput listAllProductPricePointsInput = new ListAllProductPricePointsInput
{
    Direction = SortingDirection.Asc,
    Filter = new ListPricePointsFilter
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
        Type = new List<PricePointType>
        {
            PricePointType.Catalog,
            PricePointType.Default,
            PricePointType.Custom,
        },
        Ids = new List<int>
        {
            1,
            2,
            3,
        },
    },
    Include = ListProductsPricePointsInclude.CurrencyPrices,
    Page = 1,
    PerPage = 50,
};
```

