
# Prepayment

## Structure

`Prepayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `SubscriptionId` | `int` | Required | - |
| `AmountInCents` | `long` | Required | - |
| `RemainingAmountInCents` | `long` | Required | - |
| `RefundedAmountInCents` | `long?` | Optional | - |
| `Details` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `External` | `bool` | Required | - |
| `Memo` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PaymentType` | [`PrepaymentMethod?`](../../doc/models/prepayment-method.md) | Optional | The payment type of the prepayment. |
| `CreatedAt` | `DateTimeOffset` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

Prepayment prepayment = new Prepayment
{
    Id = 38,
    SubscriptionId = 148,
    AmountInCents = 124L,
    RemainingAmountInCents = 182L,
    External = false,
    Memo = "memo2",
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    RefundedAmountInCents = 132L,
    Details = "details8",
    PaymentType = PrepaymentMethod.CreditCard,
};
```

