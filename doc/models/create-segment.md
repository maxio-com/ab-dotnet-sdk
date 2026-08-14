
# Create Segment

## Structure

`CreateSegment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SegmentProperty1Value` | [`CreateSegmentSegmentProperty1Value`](../../doc/models/containers/create-segment-segment-property-1-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty2Value` | [`CreateSegmentSegmentProperty2Value`](../../doc/models/containers/create-segment-segment-property-2-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty3Value` | [`CreateSegmentSegmentProperty3Value`](../../doc/models/containers/create-segment-segment-property-3-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty4Value` | [`CreateSegmentSegmentProperty4Value`](../../doc/models/containers/create-segment-segment-property-4-value.md) | Optional | This is a container for one-of cases. |
| `PricingScheme` | [`PricingScheme`](../../doc/models/pricing-scheme.md) | Required | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<CreateOrUpdateSegmentPrice>`](../../doc/models/create-or-update-segment-price.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateSegment createSegment = new CreateSegment
{
    PricingScheme = PricingScheme.Stairstep,
    SegmentProperty1Value = CreateSegmentSegmentProperty1Value.FromString("String7"),
    SegmentProperty2Value = CreateSegmentSegmentProperty2Value.FromString("String9"),
    SegmentProperty3Value = CreateSegmentSegmentProperty3Value.FromString("String5"),
    SegmentProperty4Value = CreateSegmentSegmentProperty4Value.FromString("String1"),
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
    },
};
```

