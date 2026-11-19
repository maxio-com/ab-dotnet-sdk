
# Wallet Purchase Preview

A price quote for a purchase, without charging anything.

## Structure

`WalletPurchasePreview`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePointId` | `int` | Required | - |
| `Currency` | `string` | Required | The three-letter currency code the `amount` is denominated in, matching the subscription's currency. |
| `Quantity` | `string` | Required | The number of units the quote is for, as a decimal string. |
| `Amount` | `string` | Required | The price for `quantity` units at this price point, as a decimal string. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletPurchasePreview walletPurchasePreview = new WalletPurchasePreview
{
    PricePointId = 98,
    Currency = "USD",
    Quantity = "quantity4",
    Amount = "amount0",
};
```

