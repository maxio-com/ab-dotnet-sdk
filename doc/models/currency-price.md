
# Currency Price

## Structure

`CurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Price` | `double?` | Optional | - |
| `FormattedPrice` | `string` | Optional | - |
| `PriceId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `Role` | [`CurrencyPriceRole?`](../../doc/models/currency-price-role.md) | Optional | Role for the price. |

## Example (as JSON)

```json
{
  "id": 88,
  "currency": "currency6",
  "price": 41.36,
  "formatted_price": "formatted_price4",
  "price_id": 178
}
```

