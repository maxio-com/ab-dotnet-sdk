
# Preview Allocations Request

## Structure

`PreviewAllocationsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Allocations` | [`List<CreateAllocation>`](../../doc/models/create-allocation.md) | Required | - |
| `EffectiveProrationDate` | `DateTime?` | Optional | To calculate proration amounts for a future time. Only within a current subscription period. Only ISO8601 format is supported. |
| `UpgradeCharge` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |
| `DowngradeCredit` | [`CreditType?`](../../doc/models/credit-type.md) | Optional | The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

PreviewAllocationsRequest previewAllocationsRequest = new PreviewAllocationsRequest
{
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
    },
    EffectiveProrationDate = DateTime.Parse("2023-12-01"),
    UpgradeCharge = CreditType.None,
    DowngradeCredit = CreditType.None,
};
```

