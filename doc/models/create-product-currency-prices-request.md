
# Create Product Currency Prices Request

## Structure

`CreateProductCurrencyPricesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyPrices` | [`List<CreateProductCurrencyPrice>`](../../doc/models/create-product-currency-price.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateProductCurrencyPricesRequest createProductCurrencyPricesRequest = new CreateProductCurrencyPricesRequest
{
    CurrencyPrices = new List<CreateProductCurrencyPrice>
    {
        new CreateProductCurrencyPrice
        {
            Currency = "currency8",
            Price = 78,
            Role = CurrencyPriceRole.Initial,
        },
    },
};
```

