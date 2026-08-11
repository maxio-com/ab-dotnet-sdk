
# Remove Payment Event

## Structure

`RemovePaymentEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Timestamp` | `DateTimeOffset` | Required | - |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |
| `EventType` | [`InvoiceEventType`](../../doc/models/invoice-event-type.md) | Required | **Default**: `InvoiceEventType.remove_payment` |
| `EventData` | [`RemovePaymentEventData`](../../doc/models/remove-payment-event-data.md) | Required | Example schema for an `remove_payment` event |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Globalization;

RemovePaymentEvent removePaymentEvent = new RemovePaymentEvent
{
    Id = 132L,
    Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Invoice = new Invoice
    {
        Id = 166L,
        Uid = "uid6",
        SiteId = 92,
        CustomerId = 204,
        SubscriptionId = 20,
        IssueDate = DateTime.Parse("2024-01-01"),
        DueDate = DateTime.Parse("2024-01-01"),
        PaidDate = DateTime.Parse("2024-01-01"),
        PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
    },
    EventType = InvoiceEventType.RemovePayment,
    EventData = new RemovePaymentEventData
    {
        TransactionId = 78,
        Memo = "memo0",
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
        Prepayment = false,
        OriginalAmount = "original_amount0",
    },
};
```

