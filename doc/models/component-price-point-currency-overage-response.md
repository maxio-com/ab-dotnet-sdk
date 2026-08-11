
# Component Price Point Currency Overage Response

## Structure

`ComponentPricePointCurrencyOverageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`CurrencyOveragePrices`](../../doc/models/currency-overage-prices.md) | Required | Extends a component price point with currency overage prices. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentPricePointCurrencyOverageResponse componentPricePointCurrencyOverageResponse = new ComponentPricePointCurrencyOverageResponse
{
    PricePoint = new CurrencyOveragePrices
    {
        Id = 248,
        Type = PricePointType.Default,
        MDefault = false,
        Name = "name0",
        PricingScheme = PricingScheme.PerUnit,
    },
};
```

