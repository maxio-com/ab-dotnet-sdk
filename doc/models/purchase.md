
# Purchase

## Structure

`Purchase`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Quantity` | [`PurchaseQuantity`](../../doc/models/containers/purchase-quantity.md) | Required | This is a container for one-of cases. |
| `PricePointId` | `int?` | Optional | The price point to purchase at. Must belong to the wallet's billing product. Defaults to the `price_point_id` set on the wallet. |
| `Memo` | `string` | Optional | (Optional) A note recorded on the resulting grant's ledger row.<br><br>**Constraints**: *Maximum Length*: `255` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

Purchase purchase = new Purchase
{
    Quantity = PurchaseQuantity.FromString("String5"),
    PricePointId = 20,
    Memo = "memo2",
};
```

