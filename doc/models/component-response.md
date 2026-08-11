
# Component Response

## Structure

`ComponentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Component` | [`Component`](../../doc/models/component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentResponse componentResponse = new ComponentResponse
{
    Component = new Component
    {
        Id = 80,
        Name = "name8",
        Handle = "handle4",
        PricingScheme = PricingScheme.PerUnit,
        UnitName = "unit_name0",
        ItemCategory = ItemCategory.EnumBusinessSoftware,
    },
};
```

