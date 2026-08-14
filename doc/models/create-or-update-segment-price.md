
# Create or Update Segment Price

## Structure

`CreateOrUpdateSegmentPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartingQuantity` | `int?` | Optional | - |
| `EndingQuantity` | `int?` | Optional | - |
| `UnitPrice` | [`CreateOrUpdateSegmentPriceUnitPrice`](../../doc/models/containers/create-or-update-segment-price-unit-price.md) | Required | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateOrUpdateSegmentPrice createOrUpdateSegmentPrice = new CreateOrUpdateSegmentPrice
{
    UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String9"),
    StartingQuantity = 98,
    EndingQuantity = 184,
};
```

