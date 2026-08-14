
# Coupon Currency Response

## Structure

`CouponCurrencyResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyPrices` | [`List<CouponCurrency>`](../../doc/models/coupon-currency.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CouponCurrencyResponse couponCurrencyResponse = new CouponCurrencyResponse
{
    CurrencyPrices = new List<CouponCurrency>
    {
        new CouponCurrency
        {
            Id = 50,
            Currency = "currency8",
            Price = 233.74,
            CouponId = 224,
        },
    },
};
```

