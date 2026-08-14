
# Sale Rep

## Structure

`SaleRep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FullName` | `string` | Optional | - |
| `SubscriptionsCount` | `int?` | Optional | - |
| `TestMode` | `bool?` | Optional | - |
| `Subscriptions` | [`List<SaleRepSubscription>`](../../doc/models/sale-rep-subscription.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SaleRep saleRep = new SaleRep
{
    Id = 78,
    FullName = "full_name0",
    SubscriptionsCount = 102,
    TestMode = false,
    Subscriptions = new List<SaleRepSubscription>
    {
        new SaleRepSubscription
        {
            Id = 202,
            SiteName = "site_name8",
            SubscriptionUrl = "subscription_url2",
            CustomerName = "customer_name8",
            CreatedAt = "created_at4",
        },
        new SaleRepSubscription
        {
            Id = 202,
            SiteName = "site_name8",
            SubscriptionUrl = "subscription_url2",
            CustomerName = "customer_name8",
            CreatedAt = "created_at4",
        },
        new SaleRepSubscription
        {
            Id = 202,
            SiteName = "site_name8",
            SubscriptionUrl = "subscription_url2",
            CustomerName = "customer_name8",
            CreatedAt = "created_at4",
        },
    },
};
```

