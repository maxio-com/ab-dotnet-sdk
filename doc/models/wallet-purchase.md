
# Wallet Purchase

A completed unit purchase.

## Structure

`WalletPurchase`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | The id of the grant this purchase created. When the wallet was overdrawn by at least the purchased quantity, the units repay the debt and the grant is still created, with `remaining` of `0` and `original` equal to the purchased quantity. |
| `PricePointId` | `int` | Required | The price point the purchase was priced at. |
| `InvoiceUid` | `string` | Required | The uid of the invoice created to collect payment for this purchase. |
| `Quantity` | `string` | Required | The number of units purchased, as a decimal string. |
| `ExpiresAt` | `DateTimeOffset?` | Required | When the purchased units expire, following the funding entitlement's grant expiration policy. `null` when the wallet has no funding entitlement or its entitlements disagree on an expiration policy. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

WalletPurchase walletPurchase = new WalletPurchase
{
    Id = 218,
    PricePointId = 96,
    InvoiceUid = "invoice_uid0",
    Quantity = "quantity6",
    ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

