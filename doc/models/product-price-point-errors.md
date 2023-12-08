
# Product Price Point Errors

## Structure

`ProductPricePointErrors`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | `string` | Optional | - |
| `Interval` | `List<string>` | Optional | - |
| `IntervalUnit` | `List<string>` | Optional | - |
| `Name` | `List<string>` | Optional | - |
| `Price` | `List<string>` | Optional | - |
| `PriceInCents` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "price_point": "can't be blank",
  "interval": [
    "Recurring Interval: cannot be blank.",
    "Recurring Interval: must be greater than or equal to 1."
  ],
  "interval_unit": [
    "Interval unit: cannot be blank.",
    "Interval unit: must be 'month' or 'day'."
  ],
  "name": [
    "Name: cannot be blank."
  ],
  "price": [
    "Price: is not a number.",
    "Price: must be greater than or equal to 0."
  ],
  "price_in_cents": [
    "Price in cents: cannot be blank."
  ]
}
```

