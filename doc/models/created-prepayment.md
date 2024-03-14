
# Created Prepayment

## Structure

`CreatedPrepayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | **Constraints**: `>= 1` |
| `SubscriptionId` | `int?` | Optional | **Constraints**: `>= 1` |
| `AmountInCents` | `long?` | Optional | **Constraints**: `>= 0.01` |
| `Memo` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `StartingBalanceInCents` | `long?` | Optional | **Constraints**: `>= 0` |
| `EndingBalanceInCents` | `long?` | Optional | - |

## Example (as JSON)

```json
{
  "id": 110,
  "subscription_id": 220,
  "amount_in_cents": 196,
  "memo": "memo6",
  "created_at": "2016-03-13T12:52:32.123Z"
}
```

