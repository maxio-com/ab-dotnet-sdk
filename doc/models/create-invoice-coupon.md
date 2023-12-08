
# Create Invoice Coupon

## Structure

`CreateInvoiceCoupon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | - |
| `Percentage` | [`CreateInvoiceCouponPercentage`](../../doc/models/containers/create-invoice-coupon-percentage.md) | Optional | This is a container for one-of cases. |
| `Amount` | [`CreateInvoiceCouponAmount`](../../doc/models/containers/create-invoice-coupon-amount.md) | Optional | This is a container for one-of cases. |
| `Description` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `ProductFamilyId` | [`CreateInvoiceCouponProductFamilyId`](../../doc/models/containers/create-invoice-coupon-product-family-id.md) | Optional | This is a container for one-of cases. |
| `CompoundingStrategy` | [`CompoundingStrategy?`](../../doc/models/compounding-strategy.md) | Optional | - |

## Example (as JSON)

```json
{
  "percentage": 50.0,
  "code": "code4",
  "amount": "String9",
  "description": "description4",
  "product_family_id": "String3"
}
```

