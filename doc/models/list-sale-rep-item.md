
# List Sale Rep Item

## Structure

`ListSaleRepItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FullName` | `string` | Optional | - |
| `SubscriptionsCount` | `int?` | Optional | - |
| `MrrData` | [`Dictionary<string, SaleRepItemMrr>`](../../doc/models/sale-rep-item-mrr.md) | Optional | - |
| `TestMode` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListSaleRepItem listSaleRepItem = new ListSaleRepItem
{
    Id = 54,
    FullName = "full_name2",
    SubscriptionsCount = 126,
    MrrData = new Dictionary<string, SaleRepItemMrr>
    {
        ["november_2019"] = new SaleRepItemMrr
        {
            Mrr = "$0.00",
            Usage = "$0.00",
            Recurring = "$0.00",
        },
        ["december_2019"] = new SaleRepItemMrr
        {
            Mrr = "$0.00",
            Usage = "$0.00",
            Recurring = "$0.00",
        },
        ["january_2020"] = new SaleRepItemMrr
        {
            Mrr = "$400.00",
            Usage = "$0.00",
            Recurring = "$400.00",
        },
    },
    TestMode = false,
};
```

