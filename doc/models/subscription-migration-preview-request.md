
# Subscription Migration Preview Request

## Structure

`SubscriptionMigrationPreviewRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Migration` | [`SubscriptionMigrationPreviewOptions`](../../doc/models/subscription-migration-preview-options.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionMigrationPreviewRequest subscriptionMigrationPreviewRequest = new SubscriptionMigrationPreviewRequest
{
    Migration = new SubscriptionMigrationPreviewOptions
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

