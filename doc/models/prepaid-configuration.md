
# Prepaid Configuration

## Structure

`PrepaidConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `InitialFundingAmountInCents` | `long?` | Optional | - |
| `ReplenishToAmountInCents` | `long?` | Optional | - |
| `AutoReplenish` | `bool?` | Optional | - |
| `ReplenishThresholdAmountInCents` | `long?` | Optional | - |

## Example (as JSON)

```json
{
  "id": 156,
  "initial_funding_amount_in_cents": 88,
  "replenish_to_amount_in_cents": 166,
  "auto_replenish": false,
  "replenish_threshold_amount_in_cents": 222
}
```

