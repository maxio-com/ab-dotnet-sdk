
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
| `Enabled` | `bool?` | Optional | (for on/off components) indicates if the component is enabled for the subscription |
| `UnitBalance` | `int?` | Optional | - |
| `Currency` | `string` | Optional | - |
| `AllocatedQuantity` | [`SubscriptionComponentAllocatedQuantity`](../../doc/models/containers/subscription-component-allocated-quantity.md) | Optional | This is a container for one-of cases. |
| `PricingScheme` | [`SubscriptionComponentPricingScheme`](../../doc/models/containers/subscription-component-pricing-scheme.md) | Optional | This is a container for one-of cases. |
| `ComponentId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `Recurring` | `bool?` | Optional | - |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.<br>Available values: `full`, `prorated`, `none`. |
| `DowngradeCredit` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.<br>Available values: `full`, `prorated`, `none`. |
| `ArchivedAt` | `string` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `PricePointHandle` | `string` | Optional | - |
| `PricePointType` | [`SubscriptionComponentPricePointType`](../../doc/models/containers/subscription-component-price-point-type.md) | Optional | This is a container for one-of cases. |
| `PricePointName` | `string` | Optional | - |
| `ProductFamilyId` | `int?` | Optional | - |
| `ProductFamilyHandle` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `UseSiteExchangeRate` | `bool?` | Optional | - |
| `Description` | `string` | Optional | - |
| `AllowFractionalQuantities` | `bool?` | Optional | - |
| `Subscription` | [`SubscriptionComponentSubscription`](../../doc/models/subscription-component-subscription.md) | Optional | An optional object, will be returned if provided `include=subscription` query param. |
| `DisplayOnHostedPage` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "id": 20,
  "name": "name8",
  "kind": "quantity_based_component",
  "unit_name": "unit_name0",
  "enabled": false
}
```

