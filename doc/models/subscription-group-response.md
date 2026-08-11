
# Subscription Group Response

## Structure

`SubscriptionGroupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionGroup` | [`SubscriptionGroup`](../../doc/models/subscription-group.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroupResponse subscriptionGroupResponse = new SubscriptionGroupResponse
{
    SubscriptionGroup = new SubscriptionGroup
    {
        Uid = "uid8",
        CustomerId = 220,
        PaymentProfile = new SubscriptionGroupPaymentProfile
        {
            Id = 44,
            FirstName = "first_name4",
            LastName = "last_name2",
            MaskedCardNumber = "masked_card_number2",
        },
        PaymentCollectionMethod = CollectionMethod.Prepaid,
        SubscriptionIds = new List<int>
        {
            74,
            75,
        },
    },
};
```

