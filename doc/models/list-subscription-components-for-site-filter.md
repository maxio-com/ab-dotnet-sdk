
# List Subscription Components for Site Filter

## Structure

`ListSubscriptionComponentsForSiteFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currencies` | `List<string>` | Optional | Allows fetching components allocation with matching currency based on provided values. Use in query `filter[currencies]=USD,EUR`.<br><br>**Constraints**: *Minimum Items*: `1` |
| `UseSiteExchangeRate` | `bool?` | Optional | Allows fetching components allocation with matching use_site_exchange_rate based on provided value. Use in query `filter[use_site_exchange_rate]=true`. |
| `Subscription` | [`SubscriptionFilter`](../../doc/models/subscription-filter.md) | Optional | Nested filter used for List Subscription Components For Site Filter |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListSubscriptionComponentsForSiteFilter listSubscriptionComponentsForSiteFilter = new ListSubscriptionComponentsForSiteFilter
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
};
```

