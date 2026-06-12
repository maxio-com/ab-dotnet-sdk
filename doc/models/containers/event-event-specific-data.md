
# Event Event Specific Data

## Class Name

`EventEventSpecificData`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`SubscriptionProductChange`](../../../doc/models/subscription-product-change.md) | EventEventSpecificData.FromSubscriptionProductChange(SubscriptionProductChange subscriptionProductChange) |
| [`SubscriptionStateChange`](../../../doc/models/subscription-state-change.md) | EventEventSpecificData.FromSubscriptionStateChange(SubscriptionStateChange subscriptionStateChange) |
| [`PaymentRelatedEvents`](../../../doc/models/payment-related-events.md) | EventEventSpecificData.FromPaymentRelatedEvents(PaymentRelatedEvents paymentRelatedEvents) |
| [`RefundSuccess`](../../../doc/models/refund-success.md) | EventEventSpecificData.FromRefundSuccess(RefundSuccess refundSuccess) |
| [`ComponentAllocationChange`](../../../doc/models/component-allocation-change.md) | EventEventSpecificData.FromComponentAllocationChange(ComponentAllocationChange componentAllocationChange) |
| [`MeteredUsage`](../../../doc/models/metered-usage.md) | EventEventSpecificData.FromMeteredUsage(MeteredUsage meteredUsage) |
| [`PrepaidUsage`](../../../doc/models/prepaid-usage.md) | EventEventSpecificData.FromPrepaidUsage(PrepaidUsage prepaidUsage) |
| [`DunningStepReached`](../../../doc/models/dunning-step-reached.md) | EventEventSpecificData.FromDunningStepReached(DunningStepReached dunningStepReached) |
| [`InvoiceIssued`](../../../doc/models/invoice-issued.md) | EventEventSpecificData.FromInvoiceIssued(InvoiceIssued invoiceIssued) |
| [`PendingCancellationChange`](../../../doc/models/pending-cancellation-change.md) | EventEventSpecificData.FromPendingCancellationChange(PendingCancellationChange pendingCancellationChange) |
| [`PrepaidSubscriptionBalanceChanged`](../../../doc/models/prepaid-subscription-balance-changed.md) | EventEventSpecificData.FromPrepaidSubscriptionBalanceChanged(PrepaidSubscriptionBalanceChanged prepaidSubscriptionBalanceChanged) |
| [`ProformaInvoiceIssued`](../../../doc/models/proforma-invoice-issued.md) | EventEventSpecificData.FromProformaInvoiceIssued(ProformaInvoiceIssued proformaInvoiceIssued) |
| [`SubscriptionGroupSignupEventData`](../../../doc/models/subscription-group-signup-event-data.md) | EventEventSpecificData.FromSubscriptionGroupSignupEventData(SubscriptionGroupSignupEventData subscriptionGroupSignupEventData) |
| [`CreditAccountBalanceChanged`](../../../doc/models/credit-account-balance-changed.md) | EventEventSpecificData.FromCreditAccountBalanceChanged(CreditAccountBalanceChanged creditAccountBalanceChanged) |
| [`PrepaymentAccountBalanceChanged`](../../../doc/models/prepayment-account-balance-changed.md) | EventEventSpecificData.FromPrepaymentAccountBalanceChanged(PrepaymentAccountBalanceChanged prepaymentAccountBalanceChanged) |
| [`PaymentCollectionMethodChanged`](../../../doc/models/payment-collection-method-changed.md) | EventEventSpecificData.FromPaymentCollectionMethodChanged(PaymentCollectionMethodChanged paymentCollectionMethodChanged) |
| [`ItemPricePointChanged`](../../../doc/models/item-price-point-changed.md) | EventEventSpecificData.FromItemPricePointChanged(ItemPricePointChanged itemPricePointChanged) |
| [`CustomFieldValueChange`](../../../doc/models/custom-field-value-change.md) | EventEventSpecificData.FromCustomFieldValueChange(CustomFieldValueChange customFieldValueChange) |
| [`ChjsTokenizationSuccess`](../../../doc/models/chjs-tokenization-success.md) | EventEventSpecificData.FromChjsTokenizationSuccess(ChjsTokenizationSuccess chjsTokenizationSuccess) |
| [`ChjsTokenizationFailure`](../../../doc/models/chjs-tokenization-failure.md) | EventEventSpecificData.FromChjsTokenizationFailure(ChjsTokenizationFailure chjsTokenizationFailure) |

## SubscriptionProductChange

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromSubscriptionProductChange(
    new SubscriptionProductChange
    {
        PreviousProductId = 126,
        NewProductId = 12,
    }
);
```

## SubscriptionStateChange

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromSubscriptionStateChange(
    new SubscriptionStateChange
    {
        PreviousSubscriptionState = "previous_subscription_state2",
        NewSubscriptionState = "new_subscription_state6",
    }
);
```

## PaymentRelatedEvents

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromPaymentRelatedEvents(
    new PaymentRelatedEvents
    {
        ProductId = 42,
        AccountTransactionId = 58,
    }
);
```

## RefundSuccess

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromRefundSuccess(
    new RefundSuccess
    {
        RefundId = 12,
        GatewayTransactionId = 182,
        ProductId = 168,
    }
);
```

## ComponentAllocationChange

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromComponentAllocationChange(
    new ComponentAllocationChange
    {
        PreviousAllocation = 94,
        NewAllocation = 102,
        ComponentId = 88,
        ComponentHandle = "component_handle8",
        Memo = "memo2",
        AllocationId = 158,
    }
);
```

## MeteredUsage

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromMeteredUsage(
    new MeteredUsage
    {
        PreviousUnitBalance = "previous_unit_balance6",
        NewUnitBalance = 80,
        UsageQuantity = 42,
        ComponentId = 4,
        ComponentHandle = "component_handle8",
        Memo = "memo2",
    }
);
```

## PrepaidUsage

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromPrepaidUsage(
    new PrepaidUsage
    {
        PreviousUnitBalance = "previous_unit_balance0",
        PreviousOverageUnitBalance = "previous_overage_unit_balance4",
        NewUnitBalance = 252,
        NewOverageUnitBalance = 224,
        UsageQuantity = 214,
        OverageUsageQuantity = 106,
        ComponentId = 176,
        ComponentHandle = "component_handle4",
        Memo = "memo8",
        AllocationDetails = new List<PrepaidUsageAllocationDetail>
        {
            new PrepaidUsageAllocationDetail
            {
            },
        },
    }
);
```

## DunningStepReached

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromDunningStepReached(
    new DunningStepReached
    {
        Dunner = new DunnerData
        {
            State = "state8",
            SubscriptionId = 194,
            RevenueAtRiskInCents = 98L,
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
            Attempts = 42,
            LastAttemptedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
        CurrentStep = new DunningStepData
        {
            DayThreshold = 198,
            Action = "action4",
            SendEmail = false,
            SendBccEmail = false,
            SendSms = false,
        },
        NextStep = new DunningStepData
        {
            DayThreshold = 30,
            Action = "action4",
            SendEmail = false,
            SendBccEmail = false,
            SendSms = false,
        },
    }
);
```

## InvoiceIssued

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromInvoiceIssued(
    new InvoiceIssued
    {
        Uid = "uid4",
        Number = "number8",
        Role = "role2",
        DueDate = DateTime.Parse("2016-03-13"),
        IssueDate = "issue_date0",
        PaidDate = "paid_date6",
        DueAmount = "due_amount6",
        PaidAmount = "paid_amount4",
        TaxAmount = "tax_amount2",
        RefundAmount = "refund_amount0",
        TotalAmount = "total_amount0",
        StatusAmount = "status_amount4",
        ProductName = "product_name0",
        ConsolidationLevel = "consolidation_level4",
        LineItems = new List<InvoiceLineItemEventData>
        {
            new InvoiceLineItemEventData
            {
            },
        },
    }
);
```

## PendingCancellationChange

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromPendingCancellationChange(
    new PendingCancellationChange
    {
        CancellationState = "cancellation_state8",
        CancelsAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    }
);
```

## PrepaidSubscriptionBalanceChanged

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromPrepaidSubscriptionBalanceChanged(
    new PrepaidSubscriptionBalanceChanged
    {
        Reason = "reason8",
        CurrentAccountBalanceInCents = 250L,
        PrepaymentAccountBalanceInCents = 44L,
        CurrentUsageAmountInCents = 242L,
    }
);
```

## ProformaInvoiceIssued

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromProformaInvoiceIssued(
    new ProformaInvoiceIssued
    {
        Uid = "uid0",
        Number = "number2",
        Role = "role6",
        DeliveryDate = DateTime.Parse("2016-03-13"),
        CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        DueAmount = "due_amount2",
        PaidAmount = "paid_amount8",
        TaxAmount = "tax_amount6",
        TotalAmount = "total_amount6",
        ProductName = "product_name6",
        LineItems = new List<InvoiceLineItemEventData>
        {
            new InvoiceLineItemEventData
            {
            },
        },
    }
);
```

## SubscriptionGroupSignupEventData

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromSubscriptionGroupSignupEventData(
    new SubscriptionGroupSignupEventData
    {
        SubscriptionGroup = new SubscriptionGroupSignupFailureData
        {
        },
        Customer = new Customer
        {
        },
    }
);
```

## CreditAccountBalanceChanged

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromCreditAccountBalanceChanged(
    new CreditAccountBalanceChanged
    {
        Reason = "reason8",
        ServiceCreditAccountBalanceInCents = 10L,
        ServiceCreditBalanceChangeInCents = 116L,
        CurrencyCode = "currency_code8",
        AtTime = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    }
);
```

## PrepaymentAccountBalanceChanged

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromPrepaymentAccountBalanceChanged(
    new PrepaymentAccountBalanceChanged
    {
        Reason = "reason4",
        PrepaymentAccountBalanceInCents = 182L,
        PrepaymentBalanceChangeInCents = 206L,
        CurrencyCode = "currency_code4",
    }
);
```

## PaymentCollectionMethodChanged

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromPaymentCollectionMethodChanged(
    new PaymentCollectionMethodChanged
    {
        PreviousValue = "previous_value4",
        CurrentValue = "current_value2",
    }
);
```

## ItemPricePointChanged

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromItemPricePointChanged(
    new ItemPricePointChanged
    {
        ItemId = 66,
        ItemType = "item_type6",
        ItemHandle = "item_handle4",
        ItemName = "item_name8",
        PreviousPricePoint = new ItemPricePointData
        {
        },
        CurrentPricePoint = new ItemPricePointData
        {
        },
    }
);
```

## CustomFieldValueChange

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromCustomFieldValueChange(
    new CustomFieldValueChange
    {
        EventType = "event_type2",
        MetafieldName = "metafield_name6",
        MetafieldId = 78,
        OldValue = "old_value2",
        NewValue = "new_value8",
        ResourceType = "resource_type2",
        ResourceId = 74,
    }
);
```

## ChjsTokenizationSuccess

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromChjsTokenizationSuccess(
    new ChjsTokenizationSuccess
    {
        PaymentProfile = new TokenizedPaymentProfile
        {
            Id = 44,
        },
    }
);
```

## ChjsTokenizationFailure

### Initialization Code

#### Example

```csharp
EventEventSpecificData value = EventEventSpecificData.FromChjsTokenizationFailure(
    new ChjsTokenizationFailure
    {
        Errors = "errors2",
    }
);
```

