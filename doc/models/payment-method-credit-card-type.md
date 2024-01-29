
# Payment Method Credit Card Type

## Structure

`PaymentMethodCreditCardType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardBrand` | `string` | Required | - |
| `CardExpiration` | `string` | Optional | - |
| `LastFour` | `string` | Optional | - |
| `MaskedCardNumber` | `string` | Required | - |
| `Type` | `string` | Required | **Default**: `"credit_card"` |

## Example (as JSON)

```json
{
  "card_brand": "card_brand0",
  "masked_card_number": "masked_card_number4",
  "type": "credit_card",
  "card_expiration": "card_expiration8",
  "last_four": "last_four0"
}
```

