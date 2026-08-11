
# Remove Payment Event Data

Example schema for an `remove_payment` event

## Structure

`RemovePaymentEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionId` | `int` | Required | Transaction ID of the original payment that was removed |
| `Memo` | `string` | Required | Memo of the original payment |
| `OriginalAmount` | `string` | Optional | Full amount of the original payment |
| `AppliedAmount` | `string` | Required | Applied amount of the original payment |
| `TransactionTime` | `DateTimeOffset` | Required | Transaction time of the original payment, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |
| `PaymentMethod` | [`InvoiceEventPayment`](../../doc/models/containers/invoice-event-payment.md) | Required | A nested data structure detailing the method of payment |
| `Prepayment` | `bool` | Required | The flag that shows whether the original payment was a prepayment or not |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Globalization;

RemovePaymentEventData removePaymentEventData = new RemovePaymentEventData
{
    TransactionId = 20,
    Memo = "memo4",
    AppliedAmount = "applied_amount8",
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    PaymentMethod = InvoiceEventPayment.FromPaymentMethodApplePay(
        new PaymentMethodApplePay
        {
            Type = InvoiceEventPaymentMethod.ApplePay,
        }
    ),
    Prepayment = false,
    OriginalAmount = "original_amount4",
};
```

