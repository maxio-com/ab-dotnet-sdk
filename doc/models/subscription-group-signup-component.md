
# Subscription Group Signup Component

## Structure

`SubscriptionGroupSignupComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | [`SubscriptionGroupSignupComponentComponentId`](../../doc/models/containers/subscription-group-signup-component-component-id.md) | Optional | This is a container for one-of cases. |
| `AllocatedQuantity` | [`SubscriptionGroupSignupComponentAllocatedQuantity`](../../doc/models/containers/subscription-group-signup-component-allocated-quantity.md) | Optional | This is a container for one-of cases. |
| `UnitBalance` | [`SubscriptionGroupSignupComponentUnitBalance`](../../doc/models/containers/subscription-group-signup-component-unit-balance.md) | Optional | This is a container for one-of cases. |
| `PricePointId` | [`SubscriptionGroupSignupComponentPricePointId`](../../doc/models/containers/subscription-group-signup-component-price-point-id.md) | Optional | This is a container for one-of cases. |
| `CustomPrice` | [`SubscriptionGroupComponentCustomPrice`](../../doc/models/subscription-group-component-custom-price.md) | Optional | Used in place of `price_point_id` to define a custom price point unique to the subscription. You still need to provide `component_id`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

SubscriptionGroupSignupComponent subscriptionGroupSignupComponent = new SubscriptionGroupSignupComponent
{
    ComponentId = SubscriptionGroupSignupComponentComponentId.FromString("String7"),
    AllocatedQuantity = SubscriptionGroupSignupComponentAllocatedQuantity.FromString("String1"),
    UnitBalance = SubscriptionGroupSignupComponentUnitBalance.FromString("String5"),
    PricePointId = SubscriptionGroupSignupComponentPricePointId.FromString("String1"),
    CustomPrice = new SubscriptionGroupComponentCustomPrice
    {
        PricingScheme = PricingScheme.Stairstep,
        Prices = new List<Price>
        {
            new Price
            {
                StartingQuantity = PriceStartingQuantity.FromNumber(242),
                UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                EndingQuantity = PriceEndingQuantity.FromNumber(40),
            },
            new Price
            {
                StartingQuantity = PriceStartingQuantity.FromNumber(242),
                UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                EndingQuantity = PriceEndingQuantity.FromNumber(40),
            },
        },
        OveragePricing = new List<ComponentCustomPrice>
        {
            new ComponentCustomPrice
            {
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(242),
                        UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                        EndingQuantity = PriceEndingQuantity.FromNumber(40),
                    },
                },
                TaxIncluded = false,
                PricingScheme = PricingScheme.Stairstep,
                Interval = 230,
                IntervalUnit = IntervalUnit.Day,
                ListPricePointId = 10,
            },
            new ComponentCustomPrice
            {
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(242),
                        UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                        EndingQuantity = PriceEndingQuantity.FromNumber(40),
                    },
                },
                TaxIncluded = false,
                PricingScheme = PricingScheme.Stairstep,
                Interval = 230,
                IntervalUnit = IntervalUnit.Day,
                ListPricePointId = 10,
            },
            new ComponentCustomPrice
            {
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(242),
                        UnitPrice = PriceUnitPrice.FromPrecision(23.26),
                        EndingQuantity = PriceEndingQuantity.FromNumber(40),
                    },
                },
                TaxIncluded = false,
                PricingScheme = PricingScheme.Stairstep,
                Interval = 230,
                IntervalUnit = IntervalUnit.Day,
                ListPricePointId = 10,
            },
        },
    },
};
```

