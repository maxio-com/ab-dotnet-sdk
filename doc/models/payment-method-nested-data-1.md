
# Payment Method Nested Data 1

A nested data structure detailing the method of payment

## Structure

`PaymentMethodNestedData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | - |
| `MaskedAccountNumber` | `string` | Required | - |
| `MaskedRoutingNumber` | `string` | Required | - |
| `CardBrand` | `string` | Required | - |
| `CardExpiration` | `string` | Optional | - |
| `LastFour` | `string` | Optional | - |
| `MaskedCardNumber` | `string` | Required | - |
| `Details` | `string` | Required | - |
| `Kind` | `string` | Required | - |
| `Memo` | `string` | Required | - |
| `Email` | `string` | Required | - |

## Example (as JSON)

```json
{
  "type": "Payment Method Nested Data1",
  "masked_account_number": "masked_account_number8",
  "masked_routing_number": "masked_routing_number8",
  "card_brand": "card_brand4",
  "card_expiration": "card_expiration2",
  "last_four": "last_four6",
  "masked_card_number": "masked_card_number0",
  "details": "details2",
  "kind": "kind0",
  "memo": "memo6",
  "email": "email4"
}
```

