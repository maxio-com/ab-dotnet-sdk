
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
| `StartDate` | `string` | Optional | - |
| `EndDate` | `string` | Optional | - |
| `PeriodType` | `string` | Optional | - |
| `ExistingBalanceInCents` | `long?` | Optional | - |

## Example (as JSON)

```json
{
  "line_items": [
    {
      "transaction_type": "credit",
      "kind": "component",
      "amount_in_cents": 24,
      "memo": "memo2",
      "discount_amount_in_cents": 172
    },
    {
      "transaction_type": "credit",
      "kind": "component",
      "amount_in_cents": 24,
      "memo": "memo2",
      "discount_amount_in_cents": 172
    },
    {
      "transaction_type": "credit",
      "kind": "component",
      "amount_in_cents": 24,
      "memo": "memo2",
      "discount_amount_in_cents": 172
    }
  ],
  "total_in_cents": 192,
  "total_discount_in_cents": 178,
  "total_tax_in_cents": 172,
  "subtotal_in_cents": 48
}
```

