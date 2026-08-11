
# Invoice Payment

## Structure

`InvoicePayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionTime` | `DateTimeOffset?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `OriginalAmount` | `string` | Optional | - |
| `AppliedAmount` | `string` | Optional | - |
| `PaymentMethod` | [`InvoicePaymentMethod`](../../doc/models/invoice-payment-method.md) | Optional | - |
| `TransactionId` | `int?` | Optional | - |
| `Prepayment` | `bool?` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |
| `GatewayUsed` | `string` | Optional | - |
| `GatewayTransactionId` | `string` | Optional | The transaction ID for the payment as returned from the payment gateway |
| `ReceivedOn` | `DateTime?` | Optional | Date reflecting when the payment was received from a customer. Must be in the past. Applicable only to<br>`external` payments. |
| `Uid` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

InvoicePayment invoicePayment = new InvoicePayment
{
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Memo = "memo6",
    OriginalAmount = "original_amount6",
    AppliedAmount = "applied_amount6",
    PaymentMethod = new InvoicePaymentMethod
    {
        Details = "details0",
        Kind = "kind8",
        Memo = "memo4",
        Type = "type0",
        CardBrand = "card_brand6",
    },
};
```

