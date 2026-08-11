
# Custom Field Value Change

## Structure

`CustomFieldValueChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EventType` | `string` | Required | - |
| `MetafieldName` | `string` | Required | - |
| `MetafieldId` | `int` | Required | - |
| `OldValue` | `string` | Required | - |
| `NewValue` | `string` | Required | - |
| `ResourceType` | `string` | Required | - |
| `ResourceId` | `int` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CustomFieldValueChange customFieldValueChange = new CustomFieldValueChange
{
    EventType = "event_type8",
    MetafieldName = "metafield_name2",
    MetafieldId = 138,
    OldValue = "old_value6",
    NewValue = "new_value2",
    ResourceType = "resource_type6",
    ResourceId = 14,
};
```

