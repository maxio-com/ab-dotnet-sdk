
# Update Currency Prices Request

## Structure

`UpdateCurrencyPricesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyPrices` | [`List<UpdateCurrencyPrice>`](../../doc/models/update-currency-price.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

UpdateCurrencyPricesRequest updateCurrencyPricesRequest = new UpdateCurrencyPricesRequest
{
    CurrencyPrices = new List<UpdateCurrencyPrice>
    {
        new UpdateCurrencyPrice
        {
            Id = 50,
            Price = 233.74,
        },
    },
};
```

