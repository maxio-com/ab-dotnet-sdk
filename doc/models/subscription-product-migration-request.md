
# Subscription Product Migration Request

## Structure

`SubscriptionProductMigrationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Migration` | [`SubscriptionProductMigration`](../../doc/models/subscription-product-migration.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionProductMigrationRequest subscriptionProductMigrationRequest = new SubscriptionProductMigrationRequest
{
    Migration = new SubscriptionProductMigration
    {
        ProductId = 158,
        ProductPricePointId = 82,
        IncludeTrial = false,
        IncludeInitialCharge = false,
        IncludeCoupons = true,
        PreservePeriod = false,
    },
};
```

