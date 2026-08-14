
# Refund Invoice Event Data

Example schema for an `refund_invoice` event

## Structure

`RefundInvoiceEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplyCredit` | `bool` | Required | If true, credit was created and applied it to the invoice. |
| `ConsolidationLevel` | [`InvoiceConsolidationLevel?`](../../doc/models/invoice-consolidation-level.md) | Optional | Consolidation level of the invoice, which is applicable to invoice consolidation. It will hold one of the following values:<br><br>* "none": A normal invoice with no consolidation.<br>* "child": An invoice segment which has been combined into a consolidated invoice.<br>* "parent": A consolidated invoice, whose contents are composed of invoice segments.<br><br>"Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.<br><br>See also the [invoice consolidation documentation](https://maxio.zendesk.com/hc/en-us/articles/24252269909389-Invoice-Consolidation). |
| `CreditNoteAttributes` | [`CreditNote`](../../doc/models/credit-note.md) | Required | - |
| `Memo` | `string` | Optional | The refund memo. |
| `OriginalAmount` | `string` | Optional | The full, original amount of the refund. |
| `PaymentId` | `int` | Required | The ID of the payment transaction to be refunded. |
| `RefundAmount` | `string` | Required | The amount of the refund. |
| `RefundId` | `int` | Required | The ID of the refund transaction. |
| `TransactionTime` | `DateTimeOffset` | Required | The time the refund was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

RefundInvoiceEventData refundInvoiceEventData = new RefundInvoiceEventData
{
    ApplyCredit = false,
    CreditNoteAttributes = new CreditNote
    {
        Uid = "uid2",
        SiteId = 72,
        CustomerId = 184,
        SubscriptionId = 0,
        Number = "number0",
    },
    PaymentId = 140,
    RefundAmount = "refund_amount8",
    RefundId = 184,
    TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ConsolidationLevel = InvoiceConsolidationLevel.Parent,
    Memo = "memo0",
    OriginalAmount = "original_amount0",
};
```

