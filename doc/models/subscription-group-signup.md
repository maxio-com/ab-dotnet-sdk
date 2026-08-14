
# Subscription Group Signup

## Structure

`SubscriptionGroupSignup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentProfileId` | `int?` | Optional | - |
| `PayerId` | `int?` | Optional | - |
| `PayerReference` | `string` | Optional | - |
| `PaymentCollectionMethod` | [`CollectionMethod?`](../../doc/models/collection-method.md) | Optional | The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`. |
| `PayerAttributes` | [`PayerAttributes`](../../doc/models/payer-attributes.md) | Optional | - |
| `CreditCardAttributes` | [`SubscriptionGroupCreditCard`](../../doc/models/subscription-group-credit-card.md) | Optional | - |
| `BankAccountAttributes` | [`SubscriptionGroupBankAccount`](../../doc/models/subscription-group-bank-account.md) | Optional | - |
| `Subscriptions` | [`List<SubscriptionGroupSignupItem>`](../../doc/models/subscription-group-signup-item.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroupSignup subscriptionGroupSignup = new SubscriptionGroupSignup
{
    Subscriptions = new List<SubscriptionGroupSignupItem>
    {
        new SubscriptionGroupSignupItem
        {
            ProductHandle = "product_handle8",
            ProductId = 144,
            ProductPricePointId = 68,
            ProductPricePointHandle = "product_price_point_handle4",
            OfferId = 40,
            Metafields = new Dictionary<string, string>
            {
                ["custom_field_name_1"] = "custom_field_value_1",
                ["custom_field_name_2"] = "custom_field_value_2",
            },
        },
    },
    PaymentProfileId = 124,
    PayerId = 146,
    PayerReference = "payer_reference0",
    PaymentCollectionMethod = CollectionMethod.Prepaid,
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

