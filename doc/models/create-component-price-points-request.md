
# Create Component Price Points Request

## Structure

`CreateComponentPricePointsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoints` | [`List<CreateComponentPricePointsRequestPricePoints>`](../../doc/models/containers/create-component-price-points-request-price-points.md) | Required | This is List of a container for any-of cases. |

## Example (as JSON)

```json
{
  "price_points": [
    {
      "name": "name0",
      "handle": "handle6",
      "pricing_scheme": "per_unit",
      "prices": [
        {
          "starting_quantity": 242,
          "ending_quantity": 40,
          "unit_price": 23.26
        },
        {
          "starting_quantity": 242,
          "ending_quantity": 40,
          "unit_price": 23.26
        },
        {
          "starting_quantity": 242,
          "ending_quantity": 40,
          "unit_price": 23.26
        }
      ],
      "use_site_exchange_rate": false
    },
    {
      "name": "name0",
      "handle": "handle6",
      "pricing_scheme": "per_unit",
      "prices": [
        {
          "starting_quantity": 242,
          "ending_quantity": 40,
          "unit_price": 23.26
        },
        {
          "starting_quantity": 242,
          "ending_quantity": 40,
          "unit_price": 23.26
        },
        {
          "starting_quantity": 242,
          "ending_quantity": 40,
          "unit_price": 23.26
        }
      ],
      "use_site_exchange_rate": false
    }
  ]
}
```

