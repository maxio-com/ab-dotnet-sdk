
# Site Summary

## Structure

`SiteSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SellerName` | `string` | Optional | - |
| `SiteName` | `string` | Optional | - |
| `SiteId` | `int?` | Optional | - |
| `SiteCurrency` | `string` | Optional | - |
| `Stats` | [`SiteStatistics`](../../doc/models/site-statistics.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SiteSummary siteSummary = new SiteSummary
{
    SellerName = "seller_name4",
    SiteName = "site_name8",
    SiteId = 252,
    SiteCurrency = "site_currency0",
    Stats = new SiteStatistics
    {
        TotalSubscriptions = 110,
        SubscriptionsToday = 228,
        TotalRevenue = "total_revenue6",
        RevenueToday = "revenue_today4",
        RevenueThisMonth = "revenue_this_month4",
    },
};
```

