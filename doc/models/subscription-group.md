
# Subscription Group

## Structure

`SubscriptionGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `CustomerId` | `int?` | Optional | - |
| `PaymentProfile` | [`SubscriptionGroupPaymentProfile`](../../doc/models/subscription-group-payment-profile.md) | Optional | - |
| `PaymentCollectionMethod` | [`CollectionMethod?`](../../doc/models/collection-method.md) | Optional | The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`. |
| `SubscriptionIds` | `List<int>` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroup subscriptionGroup = new SubscriptionGroup
{
    Uid = "uid8",
    CustomerId = 78,
    PaymentProfile = new SubscriptionGroupPaymentProfile
    {
        Id = 44,
        FirstName = "first_name4",
        LastName = "last_name2",
        MaskedCardNumber = "masked_card_number2",
    },
    PaymentCollectionMethod = CollectionMethod.Automatic,
    SubscriptionIds = new List<int>
    {
        188,
        189,
        190,
    },
};
```

