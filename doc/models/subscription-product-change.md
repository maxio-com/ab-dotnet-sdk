
# Subscription Product Change

## Structure

`SubscriptionProductChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreviousProductId` | `int` | Required | - |
| `NewProductId` | `int` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionProductChange subscriptionProductChange = new SubscriptionProductChange
{
    PreviousProductId = 104,
    NewProductId = 10,
};
```

