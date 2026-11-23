
# Create Wallet Purchase Request

Purchases prepaid units for the wallet at a price point, charging the subscription's payment method.

## Structure

`CreateWalletPurchaseRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Purchase` | [`Purchase`](../../doc/models/purchase.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateWalletPurchaseRequest createWalletPurchaseRequest = new CreateWalletPurchaseRequest
{
    Purchase = new Purchase
    {
        Quantity = PurchaseQuantity.FromString("String5"),
        PricePointId = 20,
        Memo = "memo2",
    },
};
```

