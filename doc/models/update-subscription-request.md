
# Update Subscription Request

## Structure

`UpdateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscription` | [`UpdateSubscription`](../../doc/models/update-subscription.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateSubscriptionRequest updateSubscriptionRequest = new UpdateSubscriptionRequest
{
    Subscription = new UpdateSubscription
    {
        CreditCardAttributes = new CreditCardAttributes
        {
            FullNumber = "full_number2",
            ExpirationMonth = "expiration_month6",
            ExpirationYear = "expiration_year2",
        },
        ProductHandle = "product_handle6",
        ProductId = 206,
        ProductChangeDelayed = false,
        NextProductId = "next_product_id6",
        DeferSignup = false,
        DunningCommunicationDelayTimeZone = "\"Eastern Time (US & Canada)\"",
    },
};
```

