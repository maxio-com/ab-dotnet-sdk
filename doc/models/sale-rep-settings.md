
# Sale Rep Settings

## Structure

`SaleRepSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerName` | `string` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `SiteLink` | `string` | Optional | - |
| `SiteName` | `string` | Optional | - |
| `SubscriptionMrr` | `string` | Optional | - |
| `SalesRepId` | `int?` | Optional | - |
| `SalesRepName` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SaleRepSettings saleRepSettings = new SaleRepSettings
{
    CustomerName = "customer_name6",
    SubscriptionId = 202,
    SiteLink = "site_link2",
    SiteName = "site_name6",
    SubscriptionMrr = "subscription_mrr4",
};
```

