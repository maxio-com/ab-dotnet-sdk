
# Create Currency Price

## Structure

`CreateCurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Optional | ISO code for a currency defined on the site level |
| `Price` | `double?` | Optional | Price for the price level in this currency |
| `PriceId` | `int?` | Optional | ID of the price that this corresponds with |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateCurrencyPrice createCurrencyPrice = new CreateCurrencyPrice
{
    Currency = "currency2",
    Price = 54.8,
    PriceId = 142,
};
```

