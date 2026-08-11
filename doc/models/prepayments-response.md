
# Prepayments Response

## Structure

`PrepaymentsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayments` | [`List<Prepayment>`](../../doc/models/prepayment.md) | Optional | **Constraints**: *Unique Items Required* |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

PrepaymentsResponse prepaymentsResponse = new PrepaymentsResponse
{
    Prepayments = new List<Prepayment>
    {
        new Prepayment
        {
            Id = 76,
            SubscriptionId = 186,
            AmountInCents = 94L,
            RemainingAmountInCents = 220L,
            External = false,
            Memo = "memo0",
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            RefundedAmountInCents = 170L,
            Details = "details6",
            PaymentType = PrepaymentMethod.Cash,
        },
    },
};
```

