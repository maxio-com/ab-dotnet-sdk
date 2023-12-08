
# Coupon Usage

## Structure

`CouponUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The Chargify id of the product |
| `Name` | `string` | Optional | Name of the product |
| `Signups` | `int?` | Optional | Number of times the coupon has been applied |
| `Savings` | `int?` | Optional | Dollar amount of customer savings as a result of the coupon. |
| `SavingsInCents` | `long?` | Optional | Dollar amount of customer savings as a result of the coupon. |
| `Revenue` | `int?` | Optional | Total revenue of the all subscriptions that have received a discount from this coupon. |
| `RevenueInCents` | `long?` | Optional | Total revenue of the all subscriptions that have received a discount from this coupon. |

## Example (as JSON)

```json
{
  "id": 14,
  "name": "name0",
  "signups": 34,
  "savings": 52,
  "savings_in_cents": 138
}
```

