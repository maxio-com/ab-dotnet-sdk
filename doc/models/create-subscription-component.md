
# Create Subscription Component

## Structure

`CreateSubscriptionComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | [`CreateSubscriptionComponentComponentId`](../../doc/models/containers/create-subscription-component-component-id.md) | Optional | This is a container for one-of cases. |
| `Enabled` | `bool?` | Optional | Used for on/off components only. |
| `UnitBalance` | [`CreateSubscriptionComponentUnitBalance`](../../doc/models/containers/create-subscription-component-unit-balance.md) | Optional | This is a container for one-of cases. |
| `AllocatedQuantity` | [`CreateSubscriptionComponentAllocatedQuantity`](../../doc/models/containers/create-subscription-component-allocated-quantity.md) | Optional | This is a container for one-of cases. |
| `Quantity` | `int?` | Optional | Deprecated. Use `allocated_quantity` instead. |
| `PricePointId` | [`CreateSubscriptionComponentPricePointId`](../../doc/models/containers/create-subscription-component-price-point-id.md) | Optional | This is a container for one-of cases. |
| `CustomPrice` | [`ComponentCustomPrice`](../../doc/models/component-custom-price.md) | Optional | Create or update custom pricing unique to the subscription. Used in place of `price_point_id`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateSubscriptionComponent createSubscriptionComponent = new CreateSubscriptionComponent
{
    ComponentId = CreateSubscriptionComponentComponentId.FromNumber(210),
    Enabled = false,
    UnitBalance = CreateSubscriptionComponentUnitBalance.FromNumber(12),
    AllocatedQuantity = CreateSubscriptionComponentAllocatedQuantity.FromNumber(48),
    Quantity = 134,
};
```

