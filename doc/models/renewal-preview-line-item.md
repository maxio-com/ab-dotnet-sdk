
# Renewal Preview Line Item

## Structure

`RenewalPreviewLineItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionType` | [`LineItemTransactionType?`](../../doc/models/line-item-transaction-type.md) | Optional | A handle for the line item transaction type |
| `Kind` | [`LineItemKind?`](../../doc/models/line-item-kind.md) | Optional | A handle for the line item kind |
| `AmountInCents` | `long?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `DiscountAmountInCents` | `long?` | Optional | - |
| `TaxableAmountInCents` | `long?` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `ProductName` | `string` | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |
| `ComponentName` | `string` | Optional | - |
| `ProductHandle` | `string` | Optional | - |
| `PeriodRangeStart` | `string` | Optional | - |
| `PeriodRangeEnd` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

RenewalPreviewLineItem renewalPreviewLineItem = new RenewalPreviewLineItem
{
    TransactionType = LineItemTransactionType.Adjustment,
    Kind = LineItemKind.PrepaidUsageComponent,
    AmountInCents = 32L,
    Memo = "memo0",
    DiscountAmountInCents = 228L,
};
```

