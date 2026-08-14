
# Subscription Group Payment Profile

## Structure

`SubscriptionGroupPaymentProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `MaskedCardNumber` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionGroupPaymentProfile subscriptionGroupPaymentProfile = new SubscriptionGroupPaymentProfile
{
    Id = 246,
    FirstName = "first_name6",
    LastName = "last_name4",
    MaskedCardNumber = "masked_card_number4",
};
```

