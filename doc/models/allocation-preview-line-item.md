
# Allocation Preview Line Item

## Structure

`AllocationPreviewLineItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionType` | [`LineItemTransactionType?`](../../doc/models/line-item-transaction-type.md) | Optional | A handle for the line item transaction type |
| `Kind` | [`AllocationPreviewLineItemKind?`](../../doc/models/allocation-preview-line-item-kind.md) | Optional | A handle for the line item kind for allocation preview |
| `AmountInCents` | `long?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `DiscountAmountInCents` | `long?` | Optional | - |
| `TaxableAmountInCents` | `long?` | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |
| `Direction` | [`AllocationPreviewDirection?`](../../doc/models/allocation-preview-direction.md) | Optional | Visible when using Fine-grained Component Control. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AllocationPreviewLineItem allocationPreviewLineItem = new AllocationPreviewLineItem
{
    TransactionType = LineItemTransactionType.Credit,
    Kind = AllocationPreviewLineItemKind.QuantityBasedComponent,
    AmountInCents = 236L,
    Memo = "memo6",
    DiscountAmountInCents = 40L,
};
```

