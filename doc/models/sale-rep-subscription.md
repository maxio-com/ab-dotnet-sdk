
# Sale Rep Subscription

## Structure

`SaleRepSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `SiteName` | `string` | Optional | - |
| `SubscriptionUrl` | `string` | Optional | - |
| `CustomerName` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `Mrr` | `string` | Optional | - |
| `Usage` | `string` | Optional | - |
| `Recurring` | `string` | Optional | - |
| `LastPayment` | `string` | Optional | - |
| `ChurnDate` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SaleRepSubscription saleRepSubscription = new SaleRepSubscription
{
    Id = 68,
    SiteName = "site_name8",
    SubscriptionUrl = "subscription_url2",
    CustomerName = "customer_name8",
    CreatedAt = "created_at4",
};
```

