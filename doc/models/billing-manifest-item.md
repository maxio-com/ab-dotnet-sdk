
# Billing Manifest Item

## Structure

`BillingManifestItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionType` | [`LineItemTransactionType?`](../../doc/models/line-item-transaction-type.md) | Optional | A handle for the line item transaction type |
| `Kind` | [`BillingManifestLineItemKind?`](../../doc/models/billing-manifest-line-item-kind.md) | Optional | A handle for the billing manifest line item kind |
| `AmountInCents` | `long?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `DiscountAmountInCents` | `long?` | Optional | - |
| `TaxableAmountInCents` | `long?` | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |
| `ComponentName` | `string` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `ProductHandle` | `string` | Optional | - |
| `ProductName` | `string` | Optional | - |
| `PeriodRangeStart` | `string` | Optional | - |
| `PeriodRangeEnd` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

BillingManifestItem billingManifestItem = new BillingManifestItem
{
    TransactionType = LineItemTransactionType.Payment,
    Kind = BillingManifestLineItemKind.Trial,
    AmountInCents = 148L,
    Memo = "memo0",
    DiscountAmountInCents = 88L,
};
```

