
# Update Price

## Structure

`UpdatePrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `EndingQuantity` | [`UpdatePriceEndingQuantity`](../../doc/models/containers/update-price-ending-quantity.md) | Optional | This is a container for one-of cases. |
| `UnitPrice` | [`UpdatePriceUnitPrice`](../../doc/models/containers/update-price-unit-price.md) | Optional | This is a container for one-of cases. |
| `Destroy` | `bool?` | Optional | - |
| `StartingQuantity` | [`UpdatePriceStartingQuantity`](../../doc/models/containers/update-price-starting-quantity.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "id": 18,
  "ending_quantity": 216,
  "unit_price": 166.62,
  "_destroy": false,
  "starting_quantity": 242
}
```

