
# Create or Update Percentage Coupon

## Structure

`CreateOrUpdatePercentageCoupon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | the name of the coupon |
| `Code` | `string` | Required | may contain uppercase alphanumeric characters and these special characters (which allow for email addresses to be used): “%”, “@”, “+”, “-”, “_”, and “.” |
| `Description` | `string` | Optional | - |
| `Percentage` | [`CreateOrUpdatePercentageCouponPercentage`](../../doc/models/containers/create-or-update-percentage-coupon-percentage.md) | Required | This is a container for one-of cases. |
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
  "percentage": 11.02,
  "allow_negative_balance": "allow_negative_balance8",
  "recurring": "recurring4",
  "end_date": "end_date0",
  "product_family_id": "product_family_id6"
}
```

