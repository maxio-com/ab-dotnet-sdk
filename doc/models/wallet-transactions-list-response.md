
# Wallet Transactions List Response

## Structure

`WalletTransactionsListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletTransactions` | [`List<WalletTransaction>`](../../doc/models/wallet-transaction.md) | Required | - |
| `Meta` | [`ListPublicKeysMeta`](../../doc/models/list-public-keys-meta.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

WalletTransactionsListResponse walletTransactionsListResponse = new WalletTransactionsListResponse
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
    Meta = new ListPublicKeysMeta
    {
        TotalCount = 150,
        CurrentPage = 126,
        TotalPages = 138,
        PerPage = 152,
    },
};
```

