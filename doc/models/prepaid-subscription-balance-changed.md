
# Prepaid Subscription Balance Changed

## Structure

`PrepaidSubscriptionBalanceChanged`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | - |
| `CurrentAccountBalanceInCents` | `long` | Required | - |
| `PrepaymentAccountBalanceInCents` | `long` | Required | - |
| `CurrentUsageAmountInCents` | `long` | Required | - |

## Example (as JSON)

```json
{
  "reason": "reason8",
  "current_account_balance_in_cents": 250,
  "prepayment_account_balance_in_cents": 44,
  "current_usage_amount_in_cents": 242
}
```

