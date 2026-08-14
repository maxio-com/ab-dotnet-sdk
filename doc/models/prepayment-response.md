
# Prepayment Response

## Structure

`PrepaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayment` | [`Prepayment`](../../doc/models/prepayment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

PrepaymentResponse prepaymentResponse = new PrepaymentResponse
{
    Prepayment = new Prepayment
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
    },
};
```

