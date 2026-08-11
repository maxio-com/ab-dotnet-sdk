
# Component Price Point Error Item

## Structure

`ComponentPricePointErrorItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | `int?` | Optional | - |
| `Message` | `string` | Optional | - |
| `PricePoint` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ComponentPricePointErrorItem componentPricePointErrorItem = new ComponentPricePointErrorItem
{
    ComponentId = 174,
    Message = "message2",
    PricePoint = 72,
};
```

