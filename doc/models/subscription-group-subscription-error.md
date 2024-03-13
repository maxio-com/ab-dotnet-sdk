
# Subscription Group Subscription Error

Object which contains subscription errors.

## Structure

`SubscriptionGroupSubscriptionError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Product` | `List<string>` | Optional | - |
| `ProductPricePointId` | `List<string>` | Optional | - |
| `PaymentProfile` | `List<string>` | Optional | - |
| `PaymentProfileChargifyToken` | `List<string>` | Optional | - |
| `Base` | `List<string>` | Optional | - |
| `PaymentProfileExpirationMonth` | `List<string>` | Optional | - |
| `PaymentProfileExpirationYear` | `List<string>` | Optional | - |
| `PaymentProfileFullNumber` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "product": [
    "product7",
    "product6"
  ],
  "product_price_point_id": [
    "product_price_point_id9",
    "product_price_point_id0"
  ],
  "payment_profile": [
    "payment_profile4",
    "payment_profile5"
  ],
  "payment_profile.chargify_token": [
    "payment_profile.chargify_token8",
    "payment_profile.chargify_token9"
  ],
  "base": [
    "base7",
    "base8",
    "base9"
  ]
}
```

