
# Update Price

## Structure

`UpdatePrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `EndingQuantity` | [`UpdatePriceEndingQuantity`](../../doc/models/containers/update-price-ending-quantity.md) | Optional | This is a container for one-of cases. |
| `UnitPrice` | [`UpdatePriceUnitPrice`](../../doc/models/containers/update-price-unit-price.md) | Optional | This is a container for one-of cases. |
| `Destroy` | `bool?` | Optional | - |
| `StartingQuantity` | [`UpdatePriceStartingQuantity`](../../doc/models/containers/update-price-starting-quantity.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

UpdatePrice updatePrice = new UpdatePrice
{
    Id = 206,
    EndingQuantity = UpdatePriceEndingQuantity.FromNumber(28),
    UnitPrice = UpdatePriceUnitPrice.FromPrecision(181.3),
    Destroy = false,
    StartingQuantity = UpdatePriceStartingQuantity.FromNumber(54),
};
```

