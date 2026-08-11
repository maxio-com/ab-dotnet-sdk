
# Component Currency Prices Response

## Structure

`ComponentCurrencyPricesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyPrices` | [`List<ComponentCurrencyPrice>`](../../doc/models/component-currency-price.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ComponentCurrencyPricesResponse componentCurrencyPricesResponse = new ComponentCurrencyPricesResponse
{
    CurrencyPrices = new List<ComponentCurrencyPrice>
    {
        new ComponentCurrencyPrice
        {
            Id = 50,
            Currency = "currency8",
            Price = "price4",
            FormattedPrice = "formatted_price6",
            PriceId = 116,
        },
    },
};
```

