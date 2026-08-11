
# Site Statistics

## Structure

`SiteStatistics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalSubscriptions` | `int?` | Optional | - |
| `SubscriptionsToday` | `int?` | Optional | - |
| `TotalRevenue` | `string` | Optional | - |
| `RevenueToday` | `string` | Optional | - |
| `RevenueThisMonth` | `string` | Optional | - |
| `RevenueThisYear` | `string` | Optional | - |
| `TotalCanceledSubscriptions` | `int?` | Optional | - |
| `TotalActiveSubscriptions` | `int?` | Optional | - |
| `TotalPastDueSubscriptions` | `int?` | Optional | - |
| `TotalUnpaidSubscriptions` | `int?` | Optional | - |
| `TotalDunningSubscriptions` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SiteStatistics siteStatistics = new SiteStatistics
{
    TotalSubscriptions = 168,
    SubscriptionsToday = 170,
    TotalRevenue = "total_revenue2",
    RevenueToday = "revenue_today0",
    RevenueThisMonth = "revenue_this_month0",
};
```

