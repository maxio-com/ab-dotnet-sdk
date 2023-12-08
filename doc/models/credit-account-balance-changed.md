
# Credit Account Balance Changed

## Structure

`CreditAccountBalanceChanged`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | - |
| `ServiceCreditAccountBalanceInCents` | `long` | Required | - |
| `ServiceCreditBalanceChangeInCents` | `long` | Required | - |
| `CurrencyCode` | `string` | Required | - |
| `AtTime` | `string` | Required | - |

## Example (as JSON)

```json
{
  "reason": "reason8",
  "service_credit_account_balance_in_cents": 10,
  "service_credit_balance_change_in_cents": 116,
  "currency_code": "currency_code8",
  "at_time": "at_time0"
}
```

