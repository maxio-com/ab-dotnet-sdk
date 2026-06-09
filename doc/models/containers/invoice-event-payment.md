
# Invoice Event Payment

A nested data structure detailing the method of payment

## Class Name

`InvoiceEventPayment`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`PaymentMethodApplePay`](../../../doc/models/payment-method-apple-pay.md) | InvoiceEventPayment.FromPaymentMethodApplePay(PaymentMethodApplePay paymentMethodApplePay) |
| [`PaymentMethodBankAccount`](../../../doc/models/payment-method-bank-account.md) | InvoiceEventPayment.FromPaymentMethodBankAccount(PaymentMethodBankAccount paymentMethodBankAccount) |
| [`PaymentMethodCreditCard`](../../../doc/models/payment-method-credit-card.md) | InvoiceEventPayment.FromPaymentMethodCreditCard(PaymentMethodCreditCard paymentMethodCreditCard) |
| [`PaymentMethodExternal`](../../../doc/models/payment-method-external.md) | InvoiceEventPayment.FromPaymentMethodExternal(PaymentMethodExternal paymentMethodExternal) |
| [`PaymentMethodPaypal`](../../../doc/models/payment-method-paypal.md) | InvoiceEventPayment.FromPaymentMethodPaypal(PaymentMethodPaypal paymentMethodPaypal) |

## PaymentMethodApplePay

### Initialization Code

#### Example

```csharp
InvoiceEventPayment value = InvoiceEventPayment.FromPaymentMethodApplePay(
    new PaymentMethodApplePay
    {
        Type = InvoiceEventPaymentMethod.ApplePay,
    }
);
```

## PaymentMethodBankAccount

### Initialization Code

#### Example

```csharp
InvoiceEventPayment value = InvoiceEventPayment.FromPaymentMethodBankAccount(
    new PaymentMethodBankAccount
    {
        MaskedAccountNumber = "masked_account_number2",
        MaskedRoutingNumber = "masked_routing_number2",
        Type = InvoiceEventPaymentMethod.BankAccount,
    }
);
```

## PaymentMethodCreditCard

### Initialization Code

#### Example

```csharp
InvoiceEventPayment value = InvoiceEventPayment.FromPaymentMethodCreditCard(
    new PaymentMethodCreditCard
    {
        CardBrand = "card_brand4",
        MaskedCardNumber = "masked_card_number0",
        Type = InvoiceEventPaymentMethod.CreditCard,
    }
);
```

## PaymentMethodExternal

### Initialization Code

#### Example

```csharp
InvoiceEventPayment value = InvoiceEventPayment.FromPaymentMethodExternal(
    new PaymentMethodExternal
    {
        Details = "details4",
        Kind = "kind2",
        Memo = "memo8",
        Type = InvoiceEventPaymentMethod.External,
    }
);
```

## PaymentMethodPaypal

### Initialization Code

#### Example

```csharp
InvoiceEventPayment value = InvoiceEventPayment.FromPaymentMethodPaypal(
    new PaymentMethodPaypal
    {
        Email = "email2",
        Type = InvoiceEventPaymentMethod.PaypalAccount,
    }
);
```

