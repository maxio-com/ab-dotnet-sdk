
# Subscription Group Item

## Structure

`SubscriptionGroupItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Reference` | `string` | Optional | - |
| `CustomerId` | `int?` | Optional | The ID of the customer the subscription belongs to. This is the payer unless the signup request named another customer for the subscription. |
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
    CustomerId = 64,
    ProductId = 32,
    ProductHandle = "product_handle8",
};
```

