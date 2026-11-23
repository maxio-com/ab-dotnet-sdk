
# Wallet Purchase Preview Response

## Structure

`WalletPurchasePreviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletPurchasePreviews` | [`List<WalletPurchasePreview>`](../../doc/models/wallet-purchase-preview.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

WalletPurchasePreviewResponse walletPurchasePreviewResponse = new WalletPurchasePreviewResponse
{
    WalletPurchasePreviews = new List<WalletPurchasePreview>
    {
        new WalletPurchasePreview
        {
            PricePointId = 126,
            Currency = "USD",
            Quantity = "quantity6",
            Amount = "amount2",
        },
    },
};
```

