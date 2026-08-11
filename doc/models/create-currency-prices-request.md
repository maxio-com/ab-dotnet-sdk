
# Create Currency Prices Request

## Structure

`CreateCurrencyPricesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyPrices` | [`List<CreateCurrencyPrice>`](../../doc/models/create-currency-price.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateCurrencyPricesRequest createCurrencyPricesRequest = new CreateCurrencyPricesRequest
{
    CurrencyPrices = new List<CreateCurrencyPrice>
    {
        new CreateCurrencyPrice
        {
            Currency = "currency8",
            Price = 233.74,
            PriceId = 116,
        },
    },
};
```

