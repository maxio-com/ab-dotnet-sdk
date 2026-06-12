
# Payment Profile

## Class Name

`PaymentProfile`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ApplePayPaymentProfile`](../../../doc/models/apple-pay-payment-profile.md) | PaymentProfile.FromApplePayPaymentProfile(ApplePayPaymentProfile applePayPaymentProfile) |
| [`BankAccountPaymentProfile`](../../../doc/models/bank-account-payment-profile.md) | PaymentProfile.FromBankAccountPaymentProfile(BankAccountPaymentProfile bankAccountPaymentProfile) |
| [`CreditCardPaymentProfile`](../../../doc/models/credit-card-payment-profile.md) | PaymentProfile.FromCreditCardPaymentProfile(CreditCardPaymentProfile creditCardPaymentProfile) |
| [`PaypalPaymentProfile`](../../../doc/models/paypal-payment-profile.md) | PaymentProfile.FromPaypalPaymentProfile(PaypalPaymentProfile paypalPaymentProfile) |

## ApplePayPaymentProfile

### Initialization Code

#### Example

```csharp
PaymentProfile value = PaymentProfile.FromApplePayPaymentProfile(
    new ApplePayPaymentProfile
    {
        PaymentType = PaymentType.ApplePay,
    }
);
```

## BankAccountPaymentProfile

### Initialization Code

#### Example

```csharp
PaymentProfile value = PaymentProfile.FromBankAccountPaymentProfile(
    new BankAccountPaymentProfile
    {
        PaymentType = PaymentType.BankAccount,
        Verified = false,
    }
);
```

## CreditCardPaymentProfile

### Initialization Code

#### Example

```csharp
PaymentProfile value = PaymentProfile.FromCreditCardPaymentProfile(
    new CreditCardPaymentProfile
    {
        PaymentType = PaymentType.CreditCard,
        Id = 10088716,
        FirstName = "Test",
        LastName = "Subscription",
        MaskedCardNumber = "XXXX-XXXX-XXXX-1",
        CardType = CardType.Bogus,
        ExpirationMonth = 1,
        ExpirationYear = 2022,
        CustomerId = 14543792,
        CurrentVault = CreditCardVault.Bogus,
        VaultToken = "1",
        BillingAddress = "123 Montana Way",
        BillingCity = "Billings",
        BillingState = "MT",
        BillingZip = "59101",
        BillingCountry = "US",
        CustomerVaultToken = "customer_vault_token2",
        BillingAddress2 = "",
        SiteGatewaySettingId = 1,
        GatewayHandle = "gateway_handle8",
    }
);
```

## PaypalPaymentProfile

### Initialization Code

#### Example

```csharp
PaymentProfile value = PaymentProfile.FromPaypalPaymentProfile(
    new PaypalPaymentProfile
    {
        PaymentType = PaymentType.PaypalAccount,
    }
);
```

