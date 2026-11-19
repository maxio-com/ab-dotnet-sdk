
# Wallet Grant Result Response

Returned by an adjustment: the ledger row written, plus the wallet's new balance.

## Structure

`WalletGrantResultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletTransactions` | [`List<WalletTransaction>`](../../doc/models/wallet-transaction.md) | Required | - |
| `Balance` | `string` | Required | The wallet's new balance, as a decimal string. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

WalletGrantResultResponse walletGrantResultResponse = new WalletGrantResultResponse
{
    WalletTransactions = new List<WalletTransaction>
    {
        new WalletTransaction
        {
            Id = 140,
            WalletId = 244,
            Kind = "grant",
            Amount = "-30.0",
            GrantId = 160,
        },
    },
    Balance = "balance8",
};
```

