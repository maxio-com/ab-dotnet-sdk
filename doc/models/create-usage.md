
# Create Usage

## Structure

`CreateUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Quantity` | `double?` | Optional | integer by default or decimal number if fractional quantities are enabled for the component |
| `PricePointId` | `string` | Optional | - |
| `Memo` | `string` | Optional | - |
| `BillingSchedule` | [`BillingSchedule`](../../doc/models/billing-schedule.md) | Optional | This attribute is particularly useful when you need to align billing events for different components on distinct schedules within a subscription. Please note this only works for site with Multifrequency enabled |

## Example (as JSON)

```json
{
  "quantity": 23.44,
  "price_point_id": "price_point_id0",
  "memo": "memo2",
  "billing_schedule": {
    "initial_billing_at": "2016-03-13"
  }
}
```

