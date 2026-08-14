
# Get One Time Token Request Payment Profile

## Class Name

`GetOneTimeTokenRequestPaymentProfile`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`GetOneTimeTokenPaymentProfile`](../../../doc/models/get-one-time-token-payment-profile.md) | GetOneTimeTokenRequestPaymentProfile.FromGetOneTimeTokenPaymentProfile(GetOneTimeTokenPaymentProfile getOneTimeTokenPaymentProfile) |
| [`GetOneTimeTokenBankAccountPaymentProfile`](../../../doc/models/get-one-time-token-bank-account-payment-profile.md) | GetOneTimeTokenRequestPaymentProfile.FromGetOneTimeTokenBankAccountPaymentProfile(GetOneTimeTokenBankAccountPaymentProfile getOneTimeTokenBankAccountPaymentProfile) |

## GetOneTimeTokenPaymentProfile

### Initialization Code

#### Example

```csharp
GetOneTimeTokenRequestPaymentProfile value = GetOneTimeTokenRequestPaymentProfile.FromGetOneTimeTokenPaymentProfile(
    new GetOneTimeTokenPaymentProfile
    {
        FirstName = "first_name2",
        LastName = "last_name0",
        MaskedCardNumber = "masked_card_number0",
        CardType = CardType.Routex,
        ExpirationMonth = 187.78,
        ExpirationYear = 164.44,
        CurrentVault = CreditCardVault.BraintreeBlue,
        VaultToken = "vault_token4",
        BillingAddress = "billing_address4",
        BillingCity = "billing_city0",
        BillingCountry = "billing_country6",
        BillingState = "billing_state6",
        BillingZip = "billing_zip0",
        PaymentType = "payment_type2",
        Disabled = false,
        SiteGatewaySettingId = 232,
    }
);
```

## GetOneTimeTokenBankAccountPaymentProfile

### Initialization Code

#### Example

```csharp
GetOneTimeTokenRequestPaymentProfile value = GetOneTimeTokenRequestPaymentProfile.FromGetOneTimeTokenBankAccountPaymentProfile(
    new GetOneTimeTokenBankAccountPaymentProfile
    {
        FirstName = "first_name8",
        LastName = "last_name6",
        CurrentVault = BankAccountVault.Maxp,
        VaultToken = "vault_token0",
        BillingAddress = "billing_address0",
        BillingCity = "billing_city4",
        BillingCountry = "billing_country2",
        BillingState = "billing_state8",
        BillingZip = "billing_zip6",
        BankName = "bank_name6",
        MaskedBankRoutingNumber = "masked_bank_routing_number6",
        MaskedBankAccountNumber = "masked_bank_account_number0",
        BankAccountType = BankAccountType.Checking,
        BankAccountHolderType = BankAccountHolderType.Personal,
        PaymentType = "payment_type2",
        Disabled = false,
        SiteGatewaySettingId = 254,
    }
);
```

