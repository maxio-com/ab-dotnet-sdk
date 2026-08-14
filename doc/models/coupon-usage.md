
# Coupon Usage

## Structure

`CouponUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The Chargify id of the product |
| `Name` | `string` | Optional | Name of the product |
| `Signups` | `int?` | Optional | Number of times the coupon has been applied |
| `Savings` | `int?` | Optional | Dollar amount of customer savings as a result of the coupon. |
| `SavingsInCents` | `long?` | Optional | Dollar amount of customer savings as a result of the coupon. |
| `Revenue` | `int?` | Optional | Total revenue of all subscriptions that have received a discount from this coupon. |
| `RevenueInCents` | `long?` | Optional | Total revenue of all subscriptions that have received a discount from this coupon. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CouponUsage couponUsage = new CouponUsage
{
    Id = 240,
    Name = "name8",
    Signups = 4,
    Savings = 22,
    SavingsInCents = 108L,
};
```

