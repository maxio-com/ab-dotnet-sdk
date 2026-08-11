
# Currency Prices Response

## Structure

`CurrencyPricesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyPrices` | [`List<CurrencyPrice>`](../../doc/models/currency-price.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CurrencyPricesResponse currencyPricesResponse = new CurrencyPricesResponse
{
    CurrencyPrices = new List<CurrencyPrice>
    {
        new CurrencyPrice
        {
            Id = 50,
            Currency = "currency8",
            Price = 233.74,
            FormattedPrice = "formatted_price6",
            PriceId = 116,
        },
    },
};
```

