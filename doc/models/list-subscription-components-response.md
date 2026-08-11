
# List Subscription Components Response

## Structure

`ListSubscriptionComponentsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionsComponents` | [`List<SubscriptionComponent>`](../../doc/models/subscription-component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListSubscriptionComponentsResponse listSubscriptionComponentsResponse = new ListSubscriptionComponentsResponse
{
    SubscriptionsComponents = new List<SubscriptionComponent>
    {
        new SubscriptionComponent
        {
            Id = 138,
            Name = "name2",
            Kind = ComponentKind.MeteredComponent,
            UnitName = "unit_name4",
            Enabled = false,
        },
    },
};
```

