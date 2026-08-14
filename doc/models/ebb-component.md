
# EBB Component

## Structure

`EBBComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | A name for this component that is suitable for showing customers and displaying on billing statements, i.e., "Minutes". |
| `UnitName` | `string` | Required | “The name of the unit of measurement for the component. It should be singular since it will be automatically pluralized when necessary. i.e., “message”, which may then be shown as “5 messages” on a subscription’s component line-item” |
| `Description` | `string` | Optional | A description for the component that will be displayed to the user on the hosted signup page. |
| `Handle` | `string` | Optional | A unique identifier for your use that can be used to retrieve this component in subsequent requests. Must start with a letter or number and may only contain lowercase letters, numbers, or the characters '.', ':', '-', or '_'.<br><br>**Constraints**: *Pattern*: `^[a-z0-9][a-z0-9\-_:.]*$` |
| `Taxable` | `bool?` | Optional | Boolean flag describing whether a component is taxable or not. |
| `PricingScheme` | [`PricingScheme`](../../doc/models/pricing-scheme.md) | Required | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Optional | (Not required for ‘per_unit’ pricing schemes) One or more price brackets. See [Price Bracket Rules](https://maxio.zendesk.com/hc/en-us/articles/24261149166733-Component-Pricing-Schemes#price-bracket-rules) for an overview of how price brackets work for different pricing schemes. |
| `PricePoints` | [`List<ComponentPricePointItem>`](../../doc/models/component-price-point-item.md) | Optional | - |
| `UnitPrice` | [`EBBComponentUnitPrice`](../../doc/models/containers/ebb-component-unit-price.md) | Optional | This is a container for one-of cases. |
| `TaxCode` | `string` | Optional | A string representing the tax code related to the component type. This is especially important when using AvaTax to tax based on locale. This attribute has a max length of 25 characters. |
| `HideDateRangeOnInvoice` | `bool?` | Optional | (Only available on Relationship Invoicing sites) Boolean flag describing if the service date range should show for the component on generated invoices. |
| `EventBasedBillingMetricId` | `int` | Required | The ID of an event based billing metric that will be attached to this component. |
| `Interval` | `int?` | Optional | The numerical interval. i.e., an interval of ‘30’ coupled with an interval_unit of day would mean this component's default price point would renew every 30 days. This property is only available for sites with Multifrequency enabled. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this component's default price point, either month or day. This property is only available for sites with Multifrequency enabled. |
| `UnspscCode` | `string` | Optional | (Optional) Custom UNSPSC commodity code for Level 3/CEDP payment data. When set, this value is sent as the commodity code on invoice line items for this component instead of the default derived from item_category. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

EBBComponent eBBComponent = new EBBComponent
{
    Name = "name0",
    UnitName = "unit_name2",
    PricingScheme = PricingScheme.Stairstep,
    EventBasedBillingMetricId = 36,
    Description = "description0",
    Handle = "handle6",
    Taxable = false,
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
    PricePoints = new List<ComponentPricePointItem>
    {
        new ComponentPricePointItem
        {
            Name = "name2",
            Handle = "handle8",
            PricingScheme = PricingScheme.PerUnit,
            Interval = 92,
            IntervalUnit = IntervalUnit.Day,
        },
        new ComponentPricePointItem
        {
            Name = "name2",
            Handle = "handle8",
            PricingScheme = PricingScheme.PerUnit,
            Interval = 92,
            IntervalUnit = IntervalUnit.Day,
        },
        new ComponentPricePointItem
        {
            Name = "name2",
            Handle = "handle8",
            PricingScheme = PricingScheme.PerUnit,
            Interval = 92,
            IntervalUnit = IntervalUnit.Day,
        },
    },
};
```

