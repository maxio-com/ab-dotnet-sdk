
# Scheduled Renewal Configuration Item Response

## Structure

`ScheduledRenewalConfigurationItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ScheduledRenewalConfigurationItem` | [`ScheduledRenewalConfigurationItem`](../../doc/models/scheduled-renewal-configuration-item.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ScheduledRenewalConfigurationItemResponse scheduledRenewalConfigurationItemResponse = new ScheduledRenewalConfigurationItemResponse
{
    ScheduledRenewalConfigurationItem = new ScheduledRenewalConfigurationItem
    {
        Id = 98,
        SubscriptionId = 208,
        SubscriptionRenewalConfigurationId = 108,
        ItemId = 246,
        ItemType = "item_type2",
    },
};
```

