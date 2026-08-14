
# Subscription Group Subscription Error

Object which contains subscription errors.

## Structure

`SubscriptionGroupSubscriptionError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Product` | `List<string>` | Optional | - |
| `ProductPricePointId` | `List<string>` | Optional | - |
| `PaymentProfile` | `List<string>` | Optional | - |
| `PaymentProfileChargifyToken` | `List<string>` | Optional | - |
| `Base` | `List<string>` | Optional | - |
| `PaymentProfileExpirationMonth` | `List<string>` | Optional | - |
| `PaymentProfileExpirationYear` | `List<string>` | Optional | - |
| `PaymentProfileFullNumber` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SubscriptionGroupSubscriptionError subscriptionGroupSubscriptionError = new SubscriptionGroupSubscriptionError
{
    Product = new List<string>
    {
        "product7",
        "product8",
    },
    ProductPricePointId = new List<string>
    {
        "product_price_point_id3",
        "product_price_point_id4",
    },
    PaymentProfile = new List<string>
    {
        "payment_profile8",
        "payment_profile9",
    },
    PaymentProfileChargifyToken = new List<string>
    {
        "payment_profile.chargify_token2",
        "payment_profile.chargify_token3",
    },
    MBase = new List<string>
    {
        "base1",
        "base2",
        "base3",
    },
};
```

