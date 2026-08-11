
# Credit Account Balance Changed

## Structure

`CreditAccountBalanceChanged`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | - |
| `ServiceCreditAccountBalanceInCents` | `long` | Required | - |
| `ServiceCreditBalanceChangeInCents` | `long` | Required | - |
| `CurrencyCode` | `string` | Required | - |
| `AtTime` | `DateTimeOffset` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

CreditAccountBalanceChanged creditAccountBalanceChanged = new CreditAccountBalanceChanged
{
    Reason = "reason4",
    ServiceCreditAccountBalanceInCents = 216L,
    ServiceCreditBalanceChangeInCents = 166L,
    CurrencyCode = "currency_code6",
    AtTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

