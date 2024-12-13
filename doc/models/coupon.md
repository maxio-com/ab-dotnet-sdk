
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
| `AmountInCents` | `long?` | Optional | - |
| `ProductFamilyId` | `int?` | Optional | - |
| `ProductFamilyName` | `string` | Optional | - |
| `StartDate` | `DateTimeOffset?` | Optional | - |
| `EndDate` | `DateTimeOffset?` | Optional | After the given time, this coupon code will be invalid for new signups. Recurring discounts started before this date will continue to recur even after this date. |
| `Percentage` | `string` | Optional | - |
| `Recurring` | `bool?` | Optional | - |
| `RecurringScheme` | [`RecurringScheme?`](../../doc/models/recurring-scheme.md) | Optional | - |
| `DurationPeriodCount` | `int?` | Optional | - |
| `DurationInterval` | `int?` | Optional | - |
| `DurationIntervalUnit` | `string` | Optional | - |
| `DurationIntervalSpan` | `string` | Optional | - |
| `AllowNegativeBalance` | `bool?` | Optional | If set to true, discount is not limited (credits will carry forward to next billing). |
| `ArchivedAt` | `DateTimeOffset?` | Optional | - |
| `ConversionLimit` | `string` | Optional | - |
| `Stackable` | `bool?` | Optional | A stackable coupon can be combined with other coupons on a Subscription. |
| `CompoundingStrategy` | [`CompoundingStrategy?`](../../doc/models/compounding-strategy.md) | Optional | Applicable only to stackable coupons. For `compound`, Percentage-based discounts will be calculated against the remaining price, after prior discounts have been calculated. For `full-price`, Percentage-based discounts will always be calculated against the original item price, before other discounts are applied. |
| `UseSiteExchangeRate` | `bool?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `DiscountType` | [`DiscountType?`](../../doc/models/discount-type.md) | Optional | - |
| `ExcludeMidPeriodAllocations` | `bool?` | Optional | - |
| `ApplyOnCancelAtEndOfPeriod` | `bool?` | Optional | - |
| `ApplyOnSubscriptionExpiration` | `bool?` | Optional | - |
| `CouponRestrictions` | [`List<CouponRestriction>`](../../doc/models/coupon-restriction.md) | Optional | - |
| `CurrencyPrices` | [`List<CouponCurrency>`](../../doc/models/coupon-currency.md) | Optional | Returned in read, find, and list endpoints if the query parameter is provided. |

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

