
# List Subcription Group Prepayment Item

## Structure

`ListSubcriptionGroupPrepaymentItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `SubscriptionGroupUid` | `string` | Optional | - |
| `AmountInCents` | `long?` | Optional | - |
| `RemainingAmountInCents` | `long?` | Optional | - |
| `Details` | `string` | Optional | - |
| `External` | `bool?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `PaymentType` | [`PrepaymentMethod?`](../../doc/models/prepayment-method.md) | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |

## Example (as JSON)

```json
{
  "id": 254,
  "subscription_group_uid": "subscription_group_uid6",
  "amount_in_cents": 172,
  "remaining_amount_in_cents": 142,
  "details": "details2"
}
```

