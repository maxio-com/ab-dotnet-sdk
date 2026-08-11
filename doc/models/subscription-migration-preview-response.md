
# Subscription Migration Preview Response

## Structure

`SubscriptionMigrationPreviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Migration` | [`SubscriptionMigrationPreview`](../../doc/models/subscription-migration-preview.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionMigrationPreviewResponse subscriptionMigrationPreviewResponse = new SubscriptionMigrationPreviewResponse
{
    Migration = new SubscriptionMigrationPreview
    {
        ProratedAdjustmentInCents = 196L,
        ChargeInCents = 78L,
        PaymentDueInCents = 250L,
        CreditAppliedInCents = 210L,
    },
};
```

