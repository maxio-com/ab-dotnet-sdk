
# Wallet Purchase Result Response

## Structure

`WalletPurchaseResultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletPurchases` | [`List<WalletPurchase>`](../../doc/models/wallet-purchase.md) | Required | - |
| `Balance` | `string` | Required | The wallet's new balance, as a decimal string. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

WalletPurchaseResultResponse walletPurchaseResultResponse = new WalletPurchaseResultResponse
{
    WalletPurchases = new List<WalletPurchase>
    {
        new WalletPurchase
        {
            Id = 244,
            PricePointId = 134,
            InvoiceUid = "invoice_uid0",
            Quantity = "quantity6",
            ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    },
    Balance = "balance6",
};
```

