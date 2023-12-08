
# Component Price Point Item

## Structure

`ComponentPricePointItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": "name6",
  "handle": "handle2",
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
  ]
}
```

