
# Subscription Group Signup Failure Data

## Structure

`SubscriptionGroupSignupFailureData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayerId` | `int?` | Optional | - |
| `PayerReference` | `string` | Optional | - |
| `PaymentProfileId` | `int?` | Optional | - |
| `PaymentCollectionMethod` | `string` | Optional | - |
| `PayerAttributes` | [`PayerAttributes`](../../doc/models/payer-attributes.md) | Optional | - |
| `CreditCardAttributes` | [`SubscriptionGroupCreditCard`](../../doc/models/subscription-group-credit-card.md) | Optional | - |
| `BankAccountAttributes` | [`SubscriptionGroupBankAccount`](../../doc/models/subscription-group-bank-account.md) | Optional | - |
| `Subscriptions` | [`List<SubscriptionGroupSignupItem>`](../../doc/models/subscription-group-signup-item.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupSignupFailureData subscriptionGroupSignupFailureData = new SubscriptionGroupSignupFailureData
{
    PayerId = 236,
    PayerReference = "payer_reference2",
    PaymentProfileId = 42,
    PaymentCollectionMethod = "payment_collection_method4",
    PayerAttributes = new PayerAttributes
    {
        FirstName = "first_name2",
        LastName = "last_name0",
        Email = "email4",
        CcEmails = "cc_emails2",
        Organization = "organization6",
    },
};
```

