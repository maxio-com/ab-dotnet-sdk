
# Billing Manifest

## Structure

`BillingManifest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LineItems` | [`List<BillingManifestItem>`](../../doc/models/billing-manifest-item.md) | Optional | - |
| `TotalInCents` | `long?` | Optional | - |
| `TotalDiscountInCents` | `long?` | Optional | - |
| `TotalTaxInCents` | `long?` | Optional | - |
| `SubtotalInCents` | `long?` | Optional | - |
| `StartDate` | `DateTimeOffset?` | Optional | - |
| `EndDate` | `DateTimeOffset?` | Optional | - |
| `PeriodType` | `string` | Optional | - |
| `ExistingBalanceInCents` | `long?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

BillingManifest billingManifest = new BillingManifest
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
    TotalInCents = 96L,
    TotalDiscountInCents = 174L,
    TotalTaxInCents = 76L,
    SubtotalInCents = 208L,
};
```

