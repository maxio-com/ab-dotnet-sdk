
# Allocate Components

## Structure

`AllocateComponents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProrationUpgradeScheme` | `string` | Optional | - |
| `ProrationDowngradeScheme` | `string` | Optional | - |
| `Allocations` | [`List<CreateAllocation>`](../../doc/models/create-allocation.md) | Optional | - |
| `AccrueCharge` | `bool?` | Optional | - |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `DowngradeCredit` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `PaymentCollectionMethod` | [`CollectionMethod?`](../../doc/models/collection-method.md) | Optional | (Optional) If not passed, the allocation(s) will use the payment collection method on the subscription. |
| `InitiateDunning` | `bool?` | Optional | If true, if the immediate component payment fails, initiate dunning for the subscription.<br>Otherwise, leave the charges on the subscription to pay for at renewal. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

AllocateComponents allocateComponents = new AllocateComponents
{
    ProrationUpgradeScheme = "proration_upgrade_scheme8",
    ProrationDowngradeScheme = "proration_downgrade_scheme6",
    Allocations = new List<CreateAllocation>
    {
        new CreateAllocation
        {
            Quantity = 26.48,
            DecimalQuantity = "decimal_quantity8",
            PreviousQuantity = 55.5,
            DecimalPreviousQuantity = "decimal_previous_quantity2",
            ComponentId = 242,
            Memo = "memo6",
        },
        new CreateAllocation
        {
            Quantity = 26.48,
            DecimalQuantity = "decimal_quantity8",
            PreviousQuantity = 55.5,
            DecimalPreviousQuantity = "decimal_previous_quantity2",
            ComponentId = 242,
            Memo = "memo6",
        },
        new CreateAllocation
        {
            Quantity = 26.48,
            DecimalQuantity = "decimal_quantity8",
            PreviousQuantity = 55.5,
            DecimalPreviousQuantity = "decimal_previous_quantity2",
            ComponentId = 242,
            Memo = "memo6",
        },
    },
    AccrueCharge = false,
    UpgradeCharge = CreditType.Prorated,
};
```

