
# Wallet 1

## Structure

`Wallet1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int` | Required | The subscription that will own the wallet. |
| `WalletProductId` | [`Wallet1WalletProductId`](../../doc/models/containers/wallet-1-wallet-product-id.md) | Required | This is a container for one-of cases. |
| `Name` | `string` | Optional | (Optional) A merchant-facing label for the wallet. Surrounding spaces are stripped; a blank value is stored as `null`.<br><br>**Constraints**: *Maximum Length*: `255` |
| `DepletionPolicy` | `string` | Optional | Defaults to `hard_stop`, currently the only supported value. |
| `HardStopOverflow` | [`WalletHardStopOverflow?`](../../doc/models/wallet-hard-stop-overflow.md) | Optional | Defaults to `discard`. |
| `MeterId` | `int?` | Optional | Pairs the wallet with a merchant-owned metering meter, so its balance factors in live usage (see the wallet resource's `meter` and `metered_through_at` fields). Only a `sum` or `count` meter can be paired. Requires metered wallet consumption to be enabled for the site, checked whenever this or `conversion_rate` is sent: `403` (plain text, not JSON) if it isn't. A meter id that doesn't resolve to a merchant-owned meter on this site, including a system-maintained shadow meter, is `404`. Immutable once the wallet is created. |
| `ConversionRate` | [`Wallet1ConversionRate`](../../doc/models/containers/wallet-1-conversion-rate.md) | Optional | This is a container for one-of cases. |
| `PricePointId` | `int?` | Optional | The price point used to price [Create Wallet Purchase](../../doc/controllers/wallet-purchases.md#create-wallet-purchase) calls against this wallet. Must belong to the Wallet Product, and can't be archived or a subscription-specific custom price point. Defaults to the Wallet Product's default price point. Immutable once the wallet is created. |
| `InitialBalance` | [`Wallet1InitialBalance`](../../doc/models/containers/wallet-1-initial-balance.md) | Optional | This is a container for one-of cases. |
| `InitialBalanceExpiresAt` | `string` | Optional | An expiration for the initial-balance grant. Only accepted together with a non-zero `initial_balance`, and must be in the future. Accepts either a bare calendar date (`YYYY-MM-DD`), resolved to the end of that day in the site's time zone, or a full timestamp. A calendar day that doesn't exist, such as `2027-02-30`, is rejected with `422` rather than rolled into the next month. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

Wallet1 wallet1 = new Wallet1
{
    SubscriptionId = 66,
    WalletProductId = Wallet1WalletProductId.FromNumber(126),
    Name = "name6",
    DepletionPolicy = "depletion_policy4",
    HardStopOverflow = WalletHardStopOverflow.Discard,
    MeterId = 82,
    ConversionRate = Wallet1ConversionRate.FromString("String9"),
    InitialBalance = Wallet1InitialBalance.FromString("String1"),
};
```

