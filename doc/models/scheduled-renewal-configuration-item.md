
# Scheduled Renewal Configuration Item

## Structure

`ScheduledRenewalConfigurationItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `SubscriptionRenewalConfigurationId` | `int?` | Optional | - |
| `ItemId` | `int?` | Optional | - |
| `ItemType` | `string` | Optional | - |
| `ItemSubclass` | `string` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `PricePointType` | `string` | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `DecimalQuantity` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ScheduledRenewalConfigurationItem scheduledRenewalConfigurationItem = new ScheduledRenewalConfigurationItem
{
    Id = 54,
    SubscriptionId = 164,
    SubscriptionRenewalConfigurationId = 64,
    ItemId = 202,
    ItemType = "item_type0",
};
```

