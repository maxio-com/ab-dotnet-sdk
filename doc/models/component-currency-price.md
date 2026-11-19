
# Component Currency Price

## Structure

`ComponentCurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The ID of the stored currency price. This is `null` when the price point uses the site exchange rate (`use_site_exchange_rate: true`), because the price is calculated from the rate and is not stored. |
| `Currency` | `string` | Optional | - |
| `Price` | `string` | Optional | - |
| `FormattedPrice` | `string` | Optional | - |
| `PriceId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentCurrencyPrice componentCurrencyPrice = new ComponentCurrencyPrice
{
    Id = 128,
    Currency = "currency2",
    Price = "price4",
    FormattedPrice = "formatted_price6",
    PriceId = 38,
};
```

