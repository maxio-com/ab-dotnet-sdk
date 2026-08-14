
# Allocation Settings

## Structure

`AllocationSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `DowngradeCredit` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `AccrueCharge` | `string` | Optional | Either "true" or "false". |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AllocationSettings allocationSettings = new AllocationSettings
{
    UpgradeCharge = CreditType.Prorated,
    DowngradeCredit = CreditType.Prorated,
    AccrueCharge = "accrue_charge2",
};
```

