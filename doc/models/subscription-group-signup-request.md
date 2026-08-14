
# Subscription Group Signup Request

## Structure

`SubscriptionGroupSignupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionGroup` | [`SubscriptionGroupSignup`](../../doc/models/subscription-group-signup.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroupSignupRequest subscriptionGroupSignupRequest = new SubscriptionGroupSignupRequest
{
    SubscriptionGroup = new SubscriptionGroupSignup
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
        PaymentProfileId = 128,
        PayerId = 150,
        PayerReference = "payer_reference6",
        PaymentCollectionMethod = CollectionMethod.Prepaid,
        PayerAttributes = new PayerAttributes
        {
            FirstName = "first_name2",
            LastName = "last_name0",
            Email = "email4",
            CcEmails = "cc_emails2",
            Organization = "organization6",
        },
    },
};
```

