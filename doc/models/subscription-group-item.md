
# Subscription Group Item

## Structure

`SubscriptionGroupItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Reference` | `string` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `ProductHandle` | `string` | Optional | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `ProductPricePointHandle` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `CouponCode` | `string` | Optional | - |
| `TotalRevenueInCents` | `long?` | Optional | - |
| `BalanceInCents` | `long?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupItem subscriptionGroupItem = new SubscriptionGroupItem
{
    Id = 26,
    Reference = "reference4",
    ProductId = 32,
    ProductHandle = "product_handle8",
    ProductPricePointId = 148,
};
```

