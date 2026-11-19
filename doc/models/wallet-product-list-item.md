
# Wallet Product List Item

A Wallet Product as it appears in [List Wallet Products](../../doc/controllers/wallet-products.md#list-wallet-products): the full Component field set, plus a usage count and a price point summary that only the list response reports.

## Structure

`WalletProductListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | The unique ID assigned to the component by Chargify. This ID can be used to fetch the component from the API. |
| `Name` | `string` | Optional | The name of the Component, suitable for display on statements. e.g., Text Messages. |
| `Handle` | `string` | Optional | The component API handle |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | - |
| `UnitName` | `string` | Optional | The name of the unit that the component’s usage is measured in. e.g., message |
| `UnitPrice` | `string` | Optional | The amount the customer will be charged per unit. This field is only populated for ‘per_unit’ pricing schemes, otherwise it may be null. |
| `ProductFamilyId` | `int?` | Optional | The id of the Product Family to which the Component belongs. `null` for a Wallet Product, which has no Product Family. |
| `ProductFamilyName` | `string` | Optional | The name of the Product Family to which the Component belongs. `null` for a Wallet Product, which has no Product Family. |
| `ProductFamilyHandle` | `string` | Optional | The handle of the Product Family to which the Component belongs. `null` for a Wallet Product, which has no Product Family. |
| `PricePerUnitInCents` | `long?` | Optional | deprecated - use unit_price instead. |
| `Kind` | [`ComponentKind?`](../../doc/models/component-kind.md) | Optional | A handle for the component type |
| `Archived` | `bool?` | Optional | Boolean flag describing whether a component is archived or not. |
| `Description` | `string` | Optional | The description of the component. |
| `DefaultPricePointId` | `int?` | Optional | - |
| `OveragePrices` | [`List<ComponentPrice>`](../../doc/models/component-price.md) | Optional | Applicable only to prepaid usage components. An array of overage price brackets. |
| `Prices` | [`List<ComponentPrice>`](../../doc/models/component-price.md) | Optional | An array of price brackets. If the component uses the ‘per_unit’ pricing scheme, this array will be empty. |
| `PricePointCount` | `int?` | Optional | Count for the number of price points associated with the component |
| `PricePointsUrl` | `string` | Optional | URL that points to the location to read the existing price points via GET request |
| `DefaultPricePointName` | `string` | Optional | - |
| `Taxable` | `bool?` | Optional | Boolean flag describing whether a component is taxable or not. |
| `TaxCode` | `string` | Optional | A string representing the tax code related to the component type. This is especially important when using AvaTax to tax based on locale. This attribute has a max length of 25 characters. |
| `Recurring` | `bool?` | Optional | - |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `DowngradeCredit` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `CreatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this component was created |
| `UpdatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this component was updated |
| `ArchivedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this component was archived |
| `HideDateRangeOnInvoice` | `bool?` | Optional | (Only available on Relationship Invoicing sites) Boolean flag describing if the service date range should show for the component on generated invoices. |
| `AllowFractionalQuantities` | `bool?` | Optional | - |
| `ItemCategory` | [`ItemCategory?`](../../doc/models/item-category.md) | Optional | One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other |
| `UseSiteExchangeRate` | `bool?` | Optional | - |
| `AccountingCode` | `string` | Optional | E.g. Internal ID or SKU Number |
| `EventBasedBillingMetricId` | `int?` | Optional | (Only for Event Based Components) This is an ID of a metric attached to the component. This metric is used to bill upon collected events. |
| `Interval` | `int?` | Optional | The numerical interval. e.g., an interval of ‘30’ coupled with an interval_unit of day would mean this component’s default price point would renew every 30 days. This property is only available for sites with Multifrequency enabled. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this component's default price point, either month or day. This property is only available for sites with Multifrequency enabled. |
| `UnspscCode` | `string` | Optional | (Optional) Custom UNSPSC commodity code for Level 3/CEDP payment data. When set, this value is sent as the commodity code on invoice line items for this component instead of the default derived from item_category. |
| `Features` | [`List<FeatureCatalogItem>`](../../doc/models/feature-catalog-item.md) | Optional | The active feature catalog items attached to this component. Present only when the request includes `include_features=true`. |
| `UsedBy` | [`WalletProductUsageCount`](../../doc/models/wallet-product-usage-count.md) | Optional | A rollup of what's using this Wallet Product, for the catalog listing. |
| `PricePointSummary` | [`WalletProductPricePointSummary`](../../doc/models/wallet-product-price-point-summary.md) | Optional | A summary of the Wallet Product's default price point, for rendering a catalog listing without a separate price points call. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProductListItem walletProductListItem = new WalletProductListItem
{
    Id = 146,
    Name = "name2",
    Handle = "handle8",
    PricingScheme = PricingScheme.Stairstep,
    UnitName = "unit_name4",
    ItemCategory = ItemCategory.EnumBusinessSoftware,
};
```

