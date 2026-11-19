
# Wallet Transaction Result Response

Returned by [Create Wallet Transaction](../../doc/controllers/wallet-transactions.md#create-wallet-transaction). `wallet_transactions` and `balance` are always present. `requested_amount`, `drained_amount`, and `rejected_amount` are present only when the request's `kind` was `debit`.

## Structure

`WalletTransactionResultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletTransactions` | [`List<WalletTransaction>`](../../doc/models/wallet-transaction.md) | Required | - |
| `RequestedAmount` | `string` | Optional | `kind: debit` only. The amount that was requested, as a decimal string. |
| `DrainedAmount` | `string` | Optional | `kind: debit` only. The amount actually drained from the wallet's grants, as a decimal string. |
| `RejectedAmount` | `string` | Optional | `kind: debit` only, as a decimal string. Under `hard_stop_overflow: discard`, this is the requested amount minus what the wallet could cover (`"0.0"` on a full drain). Always `"0.0"` under `allow_negative`; nothing is rejected, and the balance goes negative instead. |
| `Balance` | `string` | Required | The wallet's new balance, as a decimal string. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

WalletTransactionResultResponse walletTransactionResultResponse = new WalletTransactionResultResponse
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
    Balance = "balance0",
    RequestedAmount = "requested_amount8",
    DrainedAmount = "drained_amount8",
    RejectedAmount = "rejected_amount4",
};
```

