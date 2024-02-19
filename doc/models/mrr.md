
# MRR

## Structure

`MRR`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountInCents` | `long?` | Optional | - |
| `AmountFormatted` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `CurrencySymbol` | `string` | Optional | - |
| `Breakouts` | [`Breakouts`](../../doc/models/breakouts.md) | Optional | - |
| `AtTime` | `DateTimeOffset?` | Optional | ISO8601 timestamp |

## Example (as JSON)

```json
{
  "amount_in_cents": 208,
  "amount_formatted": "amount_formatted2",
  "currency": "currency0",
  "currency_symbol": "currency_symbol8",
  "breakouts": {
    "plan_amount_in_cents": 254,
    "plan_amount_formatted": "plan_amount_formatted0",
    "usage_amount_in_cents": 106,
    "usage_amount_formatted": "usage_amount_formatted8"
  }
}
```

