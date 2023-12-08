
# Create or Update Flat Amount Coupon

## Structure

`CreateOrUpdateFlatAmountCoupon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | the name of the coupon |
| `Code` | `string` | Required | may contain uppercase alphanumeric characters and these special characters (which allow for email addresses to be used): “%”, “@”, “+”, “-”, “_”, and “.” |
| `Description` | `string` | Optional | - |
| `AmountInCents` | `long` | Required | - |
| `AllowNegativeBalance` | `string` | Optional | - |
| `Recurring` | `string` | Optional | - |
| `EndDate` | `string` | Optional | - |
| `ProductFamilyId` | `string` | Optional | - |
| `Stackable` | `string` | Optional | - |
| `CompoundingStrategy` | [`CompoundingStrategy?`](../../doc/models/compounding-strategy.md) | Optional | - |
| `ExcludeMidPeriodAllocations` | `bool?` | Optional | - |
| `ApplyOnCancelAtEndOfPeriod` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "code": "code8",
  "description": "description0",
  "amount_in_cents": 120,
  "allow_negative_balance": "allow_negative_balance2",
  "recurring": "recurring6",
  "end_date": "end_date0",
  "product_family_id": "product_family_id4"
}
```

