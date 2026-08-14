
# Subscription Migration Preview

## Structure

`SubscriptionMigrationPreview`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProratedAdjustmentInCents` | `long?` | Optional | The amount of the prorated adjustment that would be issued for the current subscription. |
| `ChargeInCents` | `long?` | Optional | The amount of the charge that would be created for the new product. |
| `PaymentDueInCents` | `long?` | Optional | The amount of the payment due in the case of an upgrade. |
| `CreditAppliedInCents` | `long?` | Optional | Represents a credit in cents that is applied to your subscription as part of a migration process for a specific product, which reduces the amount owed for the subscription. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionMigrationPreview subscriptionMigrationPreview = new SubscriptionMigrationPreview
{
    ProratedAdjustmentInCents = 6L,
    ChargeInCents = 144L,
    PaymentDueInCents = 60L,
    CreditAppliedInCents = 20L,
};
```

