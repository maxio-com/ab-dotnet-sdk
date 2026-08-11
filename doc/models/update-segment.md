
# Update Segment

## Structure

`UpdateSegment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingScheme` | [`PricingScheme`](../../doc/models/pricing-scheme.md) | Required | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<CreateOrUpdateSegmentPrice>`](../../doc/models/create-or-update-segment-price.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

UpdateSegment updateSegment = new UpdateSegment
{
    PricingScheme = PricingScheme.Stairstep,
    Prices = new List<CreateOrUpdateSegmentPrice>
    {
        new CreateOrUpdateSegmentPrice
        {
            UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
            StartingQuantity = 64,
            EndingQuantity = 38,
        },
        new CreateOrUpdateSegmentPrice
        {
            UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
            StartingQuantity = 64,
            EndingQuantity = 38,
        },
        new CreateOrUpdateSegmentPrice
        {
            UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
            StartingQuantity = 64,
            EndingQuantity = 38,
        },
    },
};
```

