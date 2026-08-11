
# Subscription Preview Response

## Structure

`SubscriptionPreviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionPreview` | [`SubscriptionPreview`](../../doc/models/subscription-preview.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionPreviewResponse subscriptionPreviewResponse = new SubscriptionPreviewResponse
{
    SubscriptionPreview = new SubscriptionPreview
    {
        CurrentBillingManifest = new BillingManifest
        {
            LineItems = new List<BillingManifestItem>
            {
                new BillingManifestItem
                {
                    TransactionType = LineItemTransactionType.Credit,
                    Kind = BillingManifestLineItemKind.Component,
                    AmountInCents = 24L,
                    Memo = "memo2",
                    DiscountAmountInCents = 172L,
                },
            },
            TotalInCents = 38L,
            TotalDiscountInCents = 24L,
            TotalTaxInCents = 18L,
            SubtotalInCents = 150L,
        },
        NextBillingManifest = new BillingManifest
        {
            LineItems = new List<BillingManifestItem>
            {
                new BillingManifestItem
                {
                    TransactionType = LineItemTransactionType.Credit,
                    Kind = BillingManifestLineItemKind.Component,
                    AmountInCents = 24L,
                    Memo = "memo2",
                    DiscountAmountInCents = 172L,
                },
                new BillingManifestItem
                {
                    TransactionType = LineItemTransactionType.Credit,
                    Kind = BillingManifestLineItemKind.Component,
                    AmountInCents = 24L,
                    Memo = "memo2",
                    DiscountAmountInCents = 172L,
                },
                new BillingManifestItem
                {
                    TransactionType = LineItemTransactionType.Credit,
                    Kind = BillingManifestLineItemKind.Component,
                    AmountInCents = 24L,
                    Memo = "memo2",
                    DiscountAmountInCents = 172L,
                },
            },
            TotalInCents = 62L,
            TotalDiscountInCents = 208L,
            TotalTaxInCents = 42L,
            SubtotalInCents = 174L,
        },
    },
};
```

