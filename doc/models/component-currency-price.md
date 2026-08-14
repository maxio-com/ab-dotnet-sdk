
# Component Currency Price

## Structure

`ComponentCurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
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

