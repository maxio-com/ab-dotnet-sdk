
# Apply Payment Event Data

Example schema for an `apply_payment` event

## Structure

`ApplyPaymentEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConsolidationLevel` | [`InvoiceConsolidationLevel`](../../doc/models/invoice-consolidation-level.md) | Required | - |
| `Memo` | `string` | Required | The payment memo |
| `OriginalAmount` | `string` | Required | The full, original amount of the payment transaction as a string in full units. Incoming payments can be split amongst several invoices, which will result in a `applied_amount` less than the `original_amount`. Example: A $100.99 payment, of which $40.11 is applied to this invoice, will have an `original_amount` of `"100.99"`. |
| `AppliedAmount` | `string` | Required | The amount of the payment applied to this invoice. Incoming payments can be split amongst several invoices, which will result in a `applied_amount` less than the `original_amount`. Example: A $100.99 payment, of which $40.11 is applied to this invoice, will have an `applied_amount` of `"40.11"`. |
| `TransactionTime` | `DateTimeOffset` | Required | The time the payment was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |
| `PaymentMethod` | [`InvoiceEventPayment`](../../doc/models/containers/invoice-event-payment.md) | Required | A nested data structure detailing the method of payment |
| `TransactionId` | `int?` | Optional | The Chargify id of the original payment |
| `ParentInvoiceNumber` | `int?` | Optional | - |
| `RemainingPrepaymentAmount` | `string` | Optional | - |
| `Prepayment` | `bool?` | Optional | - |
| `External` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Globalization;

ApplyPaymentEventData applyPaymentEventData = new ApplyPaymentEventData
{
    ConsolidationLevel = InvoiceConsolidationLevel.Child,
    Memo = "memo0",
    OriginalAmount = "original_amount0",
    AppliedAmount = "applied_amount2",
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    PaymentMethod = InvoiceEventPayment.FromPaymentMethodApplePay(
        new PaymentMethodApplePay
        {
            Type = InvoiceEventPaymentMethod.ApplePay,
        }
    ),
    TransactionId = 142,
    ParentInvoiceNumber = 228,
    RemainingPrepaymentAmount = "remaining_prepayment_amount4",
    Prepayment = false,
    External = false,
};
```

