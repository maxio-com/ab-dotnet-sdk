
# Create Offer Component

## Structure

`CreateOfferComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `StartingQuantity` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateOfferComponent createOfferComponent = new CreateOfferComponent
{
    ComponentId = 252,
    PricePointId = 20,
    StartingQuantity = 196,
};
```

