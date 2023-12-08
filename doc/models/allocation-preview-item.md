
# Allocation Preview Item

## Structure

`AllocationPreviewItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentId` | `int?` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `Quantity` | `double?` | Optional | - |
| `PreviousQuantity` | `int?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `Timestamp` | `string` | Optional | - |
| `ProrationUpgradeScheme` | `string` | Optional | - |
| `ProrationDowngradeScheme` | `string` | Optional | - |
| `AccrueCharge` | `bool?` | Optional | - |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.<br>Available values: `full`, `prorated`, `none`. |
| `DowngradeCredit` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.<br>Available values: `full`, `prorated`, `none`. |
| `PricePointId` | `int?` | Optional | - |
| `PreviousPricePointId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "component_id": 54,
  "subscription_id": 54,
  "quantity": 173.08,
  "previous_quantity": 14,
  "memo": "memo6"
}
```

