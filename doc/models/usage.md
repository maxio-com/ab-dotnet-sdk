
# Usage

## Structure

`Usage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | **Constraints**: `>= 0` |
| `Memo` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
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
  "created_at": "2016-03-13T12:52:32.123Z",
  "price_point_id": 126,
  "quantity": 130
}
```

