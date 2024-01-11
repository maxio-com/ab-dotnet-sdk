
# Allocation Preview

## Structure

`AllocationPreview`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `string` | Optional | - |
| `EndDate` | `string` | Optional | - |
| `SubtotalInCents` | `long?` | Optional | - |
| `TotalTaxInCents` | `long?` | Optional | - |
| `TotalDiscountInCents` | `long?` | Optional | - |
| `TotalInCents` | `long?` | Optional | - |
| `Direction` | [`AllocationPreviewDirection?`](../../doc/models/allocation-preview-direction.md) | Optional | - |
| `ProrationScheme` | `string` | Optional | - |
| `LineItems` | [`List<AllocationPreviewLineItem>`](../../doc/models/allocation-preview-line-item.md) | Optional | - |
| `AccrueCharge` | `bool?` | Optional | - |
| `Allocations` | [`List<AllocationPreviewItem>`](../../doc/models/allocation-preview-item.md) | Optional | - |
| `PeriodType` | `string` | Optional | - |
| `ExistingBalanceInCents` | `long?` | Optional | An integer representing the amount of the subscription's current balance |

## Example (as JSON)

```json
{
  "start_date": "start_date2",
  "end_date": "end_date8",
  "subtotal_in_cents": 4,
  "total_tax_in_cents": 128,
  "total_discount_in_cents": 122
}
```

