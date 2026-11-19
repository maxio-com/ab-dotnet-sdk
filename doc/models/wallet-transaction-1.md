
# Wallet Transaction 1

## Structure

`WalletTransaction1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | [`Kind1`](../../doc/models/kind-1.md) | Required | Determines the direction of the movement. The amount itself is always sent positive. |
| `Amount` | [`WalletTransaction1Amount`](../../doc/models/containers/wallet-transaction-1-amount.md) | Required | This is a container for one-of cases. |
| `Memo` | `string` | Optional | **Constraints**: *Maximum Length*: `255` |
| `ExpiresAt` | `string` | Optional | An expiration for the grant this creates. Only accepted with `kind: grant`; sending it with `kind: debit` is rejected. Omit it for an evergreen grant. Accepts either a bare calendar date (`YYYY-MM-DD`), resolved to the end of that day in the site's time zone, or a full timestamp. A calendar day that doesn't exist, such as `2027-02-30`, is rejected with `422` rather than rolled into the next month. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

WalletTransaction1 walletTransaction1 = new WalletTransaction1
{
    Kind = Kind1.Grant,
    Amount = WalletTransaction1Amount.FromString("String5"),
    Memo = "memo6",
    ExpiresAt = "expires_at4",
};
```

