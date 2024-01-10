
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
| `Direction` | [`AllocationPreviewDirection?`](../../doc/models/allocation-preview-direction.md) | Optional | Visible when using Fine-grained Component Control |

## Example (as JSON)

```json
{
  "transaction_type": "credit",
  "kind": "quantity_based_component",
  "amount_in_cents": 24,
  "memo": "memo6",
  "discount_amount_in_cents": 172
}
```

