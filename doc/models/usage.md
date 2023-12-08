
# Usage

## Structure

`Usage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `Quantity` | [`UsageQuantity`](../../doc/models/containers/usage-quantity.md) | Optional | This is a container for one-of cases. |
| `OverageQuantity` | `int?` | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "id": 252,
  "memo": "memo8",
  "created_at": "created_at2",
  "price_point_id": 126,
  "quantity": 130
}
```

