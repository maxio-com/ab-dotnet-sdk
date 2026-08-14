
# Coupon Currency Request

## Structure

`CouponCurrencyRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyPrices` | [`List<UpdateCouponCurrency>`](../../doc/models/update-coupon-currency.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CouponCurrencyRequest couponCurrencyRequest = new CouponCurrencyRequest
{
    CurrencyPrices = new List<UpdateCouponCurrency>
    {
        new UpdateCouponCurrency
        {
            Currency = "currency8",
            Price = 78,
        },
    },
};
```

