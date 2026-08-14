
# Price

## Structure

`Price`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartingQuantity` | [`PriceStartingQuantity`](../../doc/models/containers/price-starting-quantity.md) | Required | This is a container for one-of cases. |
| `EndingQuantity` | [`PriceEndingQuantity`](../../doc/models/containers/price-ending-quantity.md) | Optional | This is a container for one-of cases. |
| `UnitPrice` | [`PriceUnitPrice`](../../doc/models/containers/price-unit-price.md) | Required | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

Price price = new Price
{
    StartingQuantity = PriceStartingQuantity.FromNumber(132),
    UnitPrice = PriceUnitPrice.FromPrecision(70.44),
    EndingQuantity = PriceEndingQuantity.FromNumber(6),
};
```

