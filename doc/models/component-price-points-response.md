
# Component Price Points Response

## Structure

`ComponentPricePointsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<ComponentPricePoint>`](../../doc/models/component-price-point.md) | Optional | - |
| `Meta` | [`ListPublicKeysMeta`](../../doc/models/list-public-keys-meta.md) | Optional | - |

## Example (as JSON)

```json
{
  "price_points": [
    {
      "id": 40,
      "type": "default",
      "default": false,
      "name": "name2",
      "pricing_scheme": "per_unit"
    },
    {
      "id": 40,
      "type": "default",
      "default": false,
      "name": "name2",
      "pricing_scheme": "per_unit"
    }
  ],
  "meta": {
    "total_count": 150,
    "current_page": 126,
    "total_pages": 138,
    "per_page": 152
  }
}
```

