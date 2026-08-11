
# Subscription Group Signup Error

## Structure

`SubscriptionGroupSignupError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscriptions` | [`Dictionary<string, SubscriptionGroupSubscriptionError>`](../../doc/models/subscription-group-subscription-error.md) | Optional | Object that as key have subscription position in request subscriptions array and as value subscription errors object. |
| `PayerReference` | `string` | Optional | - |
| `Payer` | [`PayerError`](../../doc/models/payer-error.md) | Optional | - |
| `SubscriptionGroup` | `List<string>` | Optional | - |
| `PaymentProfileId` | `string` | Optional | - |
| `PayerId` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroupSignupError subscriptionGroupSignupError = new SubscriptionGroupSignupError
{
    Subscriptions = new Dictionary<string, SubscriptionGroupSubscriptionError>
    {
        ["key0"] = new SubscriptionGroupSubscriptionError
        {
            Product = new List<string>
            {
                "product9",
            },
            ProductPricePointId = new List<string>
            {
                "product_price_point_id7",
            },
            PaymentProfile = new List<string>
            {
                "payment_profile2",
            },
            PaymentProfileChargifyToken = new List<string>
            {
                "payment_profile.chargify_token6",
            },
            MBase = new List<string>
            {
                "base5",
                "base6",
            },
        },
        ["key1"] = new SubscriptionGroupSubscriptionError
        {
            Product = new List<string>
            {
                "product9",
            },
            ProductPricePointId = new List<string>
            {
                "product_price_point_id7",
            },
            PaymentProfile = new List<string>
            {
                "payment_profile2",
            },
            PaymentProfileChargifyToken = new List<string>
            {
                "payment_profile.chargify_token6",
            },
            MBase = new List<string>
            {
                "base5",
                "base6",
            },
        },
        ["key2"] = new SubscriptionGroupSubscriptionError
        {
            Product = new List<string>
            {
                "product9",
            },
            ProductPricePointId = new List<string>
            {
                "product_price_point_id7",
            },
            PaymentProfile = new List<string>
            {
                "payment_profile2",
            },
            PaymentProfileChargifyToken = new List<string>
            {
                "payment_profile.chargify_token6",
            },
            MBase = new List<string>
            {
                "base5",
                "base6",
            },
        },
    },
    PayerReference = "payer_reference8",
    Payer = new PayerError
    {
        LastName = new List<string>
        {
            "last_name5",
            "last_name6",
        },
        FirstName = new List<string>
        {
            "first_name8",
        },
        Email = new List<string>
        {
            "email0",
            "email9",
        },
    },
    SubscriptionGroup = new List<string>
    {
        "subscription_group3",
        "subscription_group4",
        "subscription_group5",
    },
    PaymentProfileId = "payment_profile_id4",
};
```

