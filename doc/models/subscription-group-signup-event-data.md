
# Subscription Group Signup Event Data

## Structure

`SubscriptionGroupSignupEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionGroup` | [`SubscriptionGroupSignupFailureData`](../../doc/models/subscription-group-signup-failure-data.md) | Required | - |
| `Customer` | [`Customer`](../../doc/models/customer.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupSignupEventData subscriptionGroupSignupEventData = new SubscriptionGroupSignupEventData
{
    SubscriptionGroup = new SubscriptionGroupSignupFailureData
    {
        PayerId = 150,
        PayerReference = "payer_reference6",
        PaymentProfileId = 128,
        PaymentCollectionMethod = "payment_collection_method8",
        PayerAttributes = new PayerAttributes
        {
            FirstName = "first_name2",
            LastName = "last_name0",
            Email = "email4",
            CcEmails = "cc_emails2",
            Organization = "organization6",
        },
    },
    Customer = new Customer
    {
        FirstName = "first_name0",
        LastName = "last_name8",
        Email = "email6",
        CcEmails = "cc_emails0",
        Organization = "organization6",
    },
};
```

