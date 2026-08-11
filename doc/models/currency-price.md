
# Currency Price

## Structure

`CurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Price` | `double?` | Optional | - |
| `FormattedPrice` | `string` | Optional | - |
| `PriceId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `Role` | [`CurrencyPriceRole?`](../../doc/models/currency-price-role.md) | Optional | Role for the price. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CurrencyPrice currencyPrice = new CurrencyPrice
{
    Id = 208,
    Currency = "currency4",
    Price = 70.88,
    FormattedPrice = "formatted_price2",
    PriceId = 214,
};
```

