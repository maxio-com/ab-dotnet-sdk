
# Create Product Currency Price

## Structure

`CreateProductCurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | ISO code for one of the site level currencies. |
| `Price` | `int` | Required | Price for the given role. |
| `Role` | [`CurrencyPriceRole`](../../doc/models/currency-price-role.md) | Required | Role for the price. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateProductCurrencyPrice createProductCurrencyPrice = new CreateProductCurrencyPrice
{
    Currency = "currency2",
    Price = 78,
    Role = CurrencyPriceRole.Baseline,
};
```

