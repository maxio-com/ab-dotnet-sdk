
# Subscription Component Custom Price Segment

Custom rates for one segment of an event-based component, set on the subscription through `custom_price.segments`.

Identify the segment by the property values that occur in your events, in the same positions as the segmenting properties defined on the component's meter. Each segment in a request must have a unique combination of property values.

Property values are matched against your events as text. Send values for boolean segmenting properties as the strings `"true"` and `"false"`: JSON booleans are not supported here, and a segment whose only property value is `false` is rejected with a 422.

## Structure

`SubscriptionComponentCustomPriceSegment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SegmentProperty1Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty1Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-1-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty2Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty2Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-2-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty3Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty3Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-3-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty4Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty4Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-4-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty5Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty5Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-5-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty6Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty6Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-6-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty7Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty7Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-7-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty8Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty8Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-8-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty9Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty9Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-9-value.md) | Optional | This is a container for one-of cases. |
| `SegmentProperty10Value` | [`SubscriptionComponentCustomPriceSegmentSegmentProperty10Value`](../../doc/models/containers/subscription-component-custom-price-segment-segment-property-10-value.md) | Optional | This is a container for one-of cases. |
| `PricingScheme` | [`PricingScheme`](../../doc/models/pricing-scheme.md) | Required | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<CreateOrUpdateSegmentPrice>`](../../doc/models/create-or-update-segment-price.md) | Required | The rates for this segment. Use one price for a flat rate, or several price brackets for a tiered, volume or stairstep scheme.<br><br>**Constraints**: *Minimum Items*: `1` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

SubscriptionComponentCustomPriceSegment subscriptionComponentCustomPriceSegment = new SubscriptionComponentCustomPriceSegment
{
    PricingScheme = PricingScheme.PerUnit,
    Prices = new List<CreateOrUpdateSegmentPrice>
    {
        new CreateOrUpdateSegmentPrice
        {
            UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
            StartingQuantity = 64,
            EndingQuantity = 38,
        },
    },
    SegmentProperty1Value = SubscriptionComponentCustomPriceSegmentSegmentProperty1Value.FromString("String3"),
    SegmentProperty2Value = SubscriptionComponentCustomPriceSegmentSegmentProperty2Value.FromString("String5"),
    SegmentProperty3Value = SubscriptionComponentCustomPriceSegmentSegmentProperty3Value.FromString("String3"),
    SegmentProperty4Value = SubscriptionComponentCustomPriceSegmentSegmentProperty4Value.FromString("String7"),
    SegmentProperty5Value = SubscriptionComponentCustomPriceSegmentSegmentProperty5Value.FromString("String7"),
};
```

