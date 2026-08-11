
# Bulk Components Price Point Assignment

## Structure

`BulkComponentsPricePointAssignment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Components` | [`List<ComponentPricePointAssignment>`](../../doc/models/component-price-point-assignment.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

BulkComponentsPricePointAssignment bulkComponentsPricePointAssignment = new BulkComponentsPricePointAssignment
{
    Components = new List<ComponentPricePointAssignment>
    {
        new ComponentPricePointAssignment
        {
            ComponentId = 108,
            PricePoint = ComponentPricePointAssignmentPricePoint.FromString("String5"),
        },
    },
};
```

