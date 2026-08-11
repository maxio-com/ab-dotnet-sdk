
# Subscription Component

## Structure

`SubscriptionComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Kind` | [`ComponentKind?`](../../doc/models/component-kind.md) | Optional | A handle for the component type |
| `UnitName` | `string` | Optional | - |
| `Enabled` | `bool?` | Optional | (for on/off components) indicates if the component is enabled for the subscription. |
| `UnitBalance` | [`SubscriptionComponentUnitBalance`](../../doc/models/containers/subscription-component-unit-balance.md) | Optional | This is a container for one-of cases. |
| `Currency` | `string` | Optional | - |
| `AllocatedQuantity` | [`SubscriptionComponentAllocatedQuantity`](../../doc/models/containers/subscription-component-allocated-quantity.md) | Optional | This is a container for one-of cases. |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `Recurring` | `bool?` | Optional | - |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `DowngradeCredit` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `ArchivedAt` | `DateTimeOffset?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `PricePointHandle` | `string` | Optional | - |
| `PricePointType` | [`PricePointType?`](../../doc/models/price-point-type.md) | Optional | - |
| `PricePointName` | `string` | Optional | - |
| `ProductFamilyId` | `int?` | Optional | - |
| `ProductFamilyHandle` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `UseSiteExchangeRate` | `bool?` | Optional | - |
| `Description` | `string` | Optional | - |
| `AllowFractionalQuantities` | `bool?` | Optional | - |
| `Subscription` | [`SubscriptionComponentSubscription`](../../doc/models/subscription-component-subscription.md) | Optional | (Optional) Object that will be returned if the `include=subscription` query param is provided. |
| `HistoricUsages` | [`List<HistoricUsage>`](../../doc/models/historic-usage.md) | Optional | - |
| `DisplayOnHostedPage` | `bool?` | Optional | - |
| `Interval` | `int?` | Optional | The numerical interval. e.g., an interval of '30' coupled with an interval_unit of day would mean this component price point would renew every 30 days. This property is only available for sites with Multifrequency enabled. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this component price point, either month or day. This property is only available for sites with Multifrequency enabled. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SubscriptionComponent subscriptionComponent = new SubscriptionComponent
{
    Id = 254,
    Name = "name8",
    Kind = ComponentKind.QuantityBasedComponent,
    UnitName = "unit_name0",
    Enabled = false,
};
```

