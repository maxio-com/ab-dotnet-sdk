
# Prepayment

## Structure

`Prepayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `SubscriptionId` | `int` | Required | - |
| `AmountInCents` | `long` | Required | - |
| `RemainingAmountInCents` | `long` | Required | - |
| `RefundedAmountInCents` | `long?` | Optional | - |
| `Details` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `External` | `bool` | Required | - |
| `Memo` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PaymentType` | [`PrepaymentMethod?`](../../doc/models/prepayment-method.md) | Optional | The payment type of the prepayment. |
| `CreatedAt` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

## Example (as JSON)

```json
{
  "id": 50,
  "subscription_id": 160,
  "amount_in_cents": 120,
  "remaining_amount_in_cents": 194,
  "refunded_amount_in_cents": 144,
  "details": "details4",
  "external": false,
  "memo": "memo8",
  "payment_type": "cash",
  "created_at": "created_at8"
}
```

