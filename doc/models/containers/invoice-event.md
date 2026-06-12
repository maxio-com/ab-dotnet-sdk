
# Invoice Event

## Class Name

`InvoiceEvent`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ApplyCreditNoteEvent`](../../../doc/models/apply-credit-note-event.md) | InvoiceEvent.FromApplyCreditNoteEvent(ApplyCreditNoteEvent applyCreditNoteEvent) |
| [`ApplyDebitNoteEvent`](../../../doc/models/apply-debit-note-event.md) | InvoiceEvent.FromApplyDebitNoteEvent(ApplyDebitNoteEvent applyDebitNoteEvent) |
| [`ApplyPaymentEvent`](../../../doc/models/apply-payment-event.md) | InvoiceEvent.FromApplyPaymentEvent(ApplyPaymentEvent applyPaymentEvent) |
| [`BackportInvoiceEvent`](../../../doc/models/backport-invoice-event.md) | InvoiceEvent.FromBackportInvoiceEvent(BackportInvoiceEvent backportInvoiceEvent) |
| [`ChangeChargebackStatusEvent`](../../../doc/models/change-chargeback-status-event.md) | InvoiceEvent.FromChangeChargebackStatusEvent(ChangeChargebackStatusEvent changeChargebackStatusEvent) |
| [`ChangeInvoiceCollectionMethodEvent`](../../../doc/models/change-invoice-collection-method-event.md) | InvoiceEvent.FromChangeInvoiceCollectionMethodEvent(ChangeInvoiceCollectionMethodEvent changeInvoiceCollectionMethodEvent) |
| [`ChangeInvoiceStatusEvent`](../../../doc/models/change-invoice-status-event.md) | InvoiceEvent.FromChangeInvoiceStatusEvent(ChangeInvoiceStatusEvent changeInvoiceStatusEvent) |
| [`CreateCreditNoteEvent`](../../../doc/models/create-credit-note-event.md) | InvoiceEvent.FromCreateCreditNoteEvent(CreateCreditNoteEvent createCreditNoteEvent) |
| [`CreateDebitNoteEvent`](../../../doc/models/create-debit-note-event.md) | InvoiceEvent.FromCreateDebitNoteEvent(CreateDebitNoteEvent createDebitNoteEvent) |
| [`FailedPaymentEvent`](../../../doc/models/failed-payment-event.md) | InvoiceEvent.FromFailedPaymentEvent(FailedPaymentEvent failedPaymentEvent) |
| [`IssueInvoiceEvent`](../../../doc/models/issue-invoice-event.md) | InvoiceEvent.FromIssueInvoiceEvent(IssueInvoiceEvent issueInvoiceEvent) |
| [`RefundInvoiceEvent`](../../../doc/models/refund-invoice-event.md) | InvoiceEvent.FromRefundInvoiceEvent(RefundInvoiceEvent refundInvoiceEvent) |
| [`RemovePaymentEvent`](../../../doc/models/remove-payment-event.md) | InvoiceEvent.FromRemovePaymentEvent(RemovePaymentEvent removePaymentEvent) |
| [`VoidInvoiceEvent`](../../../doc/models/void-invoice-event.md) | InvoiceEvent.FromVoidInvoiceEvent(VoidInvoiceEvent voidInvoiceEvent) |
| [`VoidRemainderEvent`](../../../doc/models/void-remainder-event.md) | InvoiceEvent.FromVoidRemainderEvent(VoidRemainderEvent voidRemainderEvent) |

## ApplyCreditNoteEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromApplyCreditNoteEvent(
    new ApplyCreditNoteEvent
    {
        Id = 214L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.ApplyCreditNote,
        EventData = new ApplyCreditNoteEventData
        {
            Uid = "uid6",
            CreditNoteNumber = "credit_note_number0",
            CreditNoteUid = "credit_note_uid0",
            OriginalAmount = "original_amount0",
            AppliedAmount = "applied_amount2",
        },
    }
);
```

## ApplyDebitNoteEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromApplyDebitNoteEvent(
    new ApplyDebitNoteEvent
    {
        Id = 164L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.ApplyDebitNote,
        EventData = new ApplyDebitNoteEventData
        {
            DebitNoteNumber = "debit_note_number6",
            DebitNoteUid = "debit_note_uid2",
            OriginalAmount = "original_amount0",
            AppliedAmount = "applied_amount2",
        },
    }
);
```

## ApplyPaymentEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromApplyPaymentEvent(
    new ApplyPaymentEvent
    {
        Id = 234L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.ApplyPayment,
        EventData = new ApplyPaymentEventData
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
        },
    }
);
```

## BackportInvoiceEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromBackportInvoiceEvent(
    new BackportInvoiceEvent
    {
        Id = 78L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.BackportInvoice,
        EventData = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
    }
);
```

## ChangeChargebackStatusEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromChangeChargebackStatusEvent(
    new ChangeChargebackStatusEvent
    {
        Id = 214L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.ChangeChargebackStatus,
        EventData = new ChangeChargebackStatusEventData
        {
            ChargebackStatus = ChargebackStatus.Won,
        },
    }
);
```

## ChangeInvoiceCollectionMethodEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromChangeInvoiceCollectionMethodEvent(
    new ChangeInvoiceCollectionMethodEvent
    {
        Id = 246L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.ChangeInvoiceCollectionMethod,
        EventData = new ChangeInvoiceCollectionMethodEventData
        {
            FromCollectionMethod = "from_collection_method4",
            ToCollectionMethod = "to_collection_method8",
        },
    }
);
```

## ChangeInvoiceStatusEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromChangeInvoiceStatusEvent(
    new ChangeInvoiceStatusEvent
    {
        Id = 92L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.ChangeInvoiceStatus,
        EventData = new ChangeInvoiceStatusEventData
        {
            FromStatus = InvoiceStatus.Open,
            ToStatus = InvoiceStatus.Pending,
        },
    }
);
```

## CreateCreditNoteEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromCreateCreditNoteEvent(
    new CreateCreditNoteEvent
    {
        Id = 28L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.CreateCreditNote,
        EventData = new CreditNote
        {
        },
    }
);
```

## CreateDebitNoteEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromCreateDebitNoteEvent(
    new CreateDebitNoteEvent
    {
        Id = 98L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.CreateDebitNote,
        EventData = new DebitNote
        {
        },
    }
);
```

## FailedPaymentEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromFailedPaymentEvent(
    new FailedPaymentEvent
    {
        Id = 120L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.FailedPayment,
        EventData = new FailedPaymentEventData
        {
            AmountInCents = 220,
            AppliedAmount = 194,
            PaymentMethod = InvoicePaymentMethodType.Cash,
            TransactionId = 78,
        },
    }
);
```

## IssueInvoiceEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromIssueInvoiceEvent(
    new IssueInvoiceEvent
    {
        Id = 130L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.IssueInvoice,
        EventData = new IssueInvoiceEventData
        {
            ConsolidationLevel = InvoiceConsolidationLevel.Child,
            FromStatus = InvoiceStatus.Open,
            ToStatus = InvoiceStatus.Pending,
            DueAmount = "due_amount8",
            TotalAmount = "total_amount2",
        },
    }
);
```

## RefundInvoiceEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromRefundInvoiceEvent(
    new RefundInvoiceEvent
    {
        Id = 54L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.RefundInvoice,
        EventData = new RefundInvoiceEventData
        {
            ApplyCredit = false,
            CreditNoteAttributes = new CreditNote
            {
            },
            PaymentId = 204,
            RefundAmount = "refund_amount8",
            RefundId = 248,
            TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    }
);
```

## RemovePaymentEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromRemovePaymentEvent(
    new RemovePaymentEvent
    {
        Id = 236L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
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
        },
    }
);
```

## VoidInvoiceEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromVoidInvoiceEvent(
    new VoidInvoiceEvent
    {
        Id = 16L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.VoidInvoice,
        EventData = new VoidInvoiceEventData
        {
            CreditNoteAttributes = new CreditNote
            {
            },
            Memo = "memo0",
            AppliedAmount = "applied_amount2",
            TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            IsAdvanceInvoice = false,
            Reason = "reason2",
        },
    }
);
```

## VoidRemainderEvent

### Initialization Code

#### Example

```csharp
InvoiceEvent value = InvoiceEvent.FromVoidRemainderEvent(
    new VoidRemainderEvent
    {
        Id = 128L,
        Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Invoice = new Invoice
        {
            IssueDate = DateTime.Parse("2024-01-01"),
            DueDate = DateTime.Parse("2024-01-01"),
            PaidDate = DateTime.Parse("2024-01-01"),
            PublicUrlExpiresOn = DateTime.Parse("2024-01-21"),
        },
        EventType = InvoiceEventType.VoidRemainder,
        EventData = new VoidRemainderEventData
        {
            CreditNoteAttributes = new CreditNote
            {
            },
            Memo = "memo0",
            AppliedAmount = "applied_amount2",
            TransactionTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    }
);
```

