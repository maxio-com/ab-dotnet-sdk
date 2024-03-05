
# Coupon

## Structure

`Coupon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Code` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Amount` | `double?` | Optional | - |
| `AmountInCents` | `int?` | Optional | - |
| `ProductFamilyId` | `int?` | Optional | - |
| `ProductFamilyName` | `string` | Optional | - |
| `StartDate` | `DateTimeOffset?` | Optional | - |
| `EndDate` | `DateTimeOffset?` | Optional | - |
| `Percentage` | `string` | Optional | - |
| `Recurring` | `bool?` | Optional | - |
| `RecurringScheme` | [`RecurringScheme?`](../../doc/models/recurring-scheme.md) | Optional | - |
| `DurationPeriodCount` | `int?` | Optional | - |
| `DurationInterval` | `int?` | Optional | - |
| `DurationIntervalUnit` | `string` | Optional | - |
| `DurationIntervalSpan` | `string` | Optional | - |
| `AllowNegativeBalance` | `bool?` | Optional | - |
| `ArchivedAt` | `DateTimeOffset?` | Optional | - |
| `ConversionLimit` | `string` | Optional | - |
| `Stackable` | `bool?` | Optional | - |
| `CompoundingStrategy` | [`CouponCompoundingStrategy`](../../doc/models/containers/coupon-compounding-strategy.md) | Optional | This is a container for any-of cases. |
| `UseSiteExchangeRate` | `bool?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `DiscountType` | [`DiscountType?`](../../doc/models/discount-type.md) | Optional | - |
| `ExcludeMidPeriodAllocations` | `bool?` | Optional | - |
| `ApplyOnCancelAtEndOfPeriod` | `bool?` | Optional | - |
| `ApplyOnSubscriptionExpiration` | `bool?` | Optional | - |
| `CouponRestrictions` | [`List<CouponRestriction>`](../../doc/models/coupon-restriction.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": 22,
  "name": "name2",
  "code": "code0",
  "description": "description2",
  "amount": 62.64
}
```

