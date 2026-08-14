
# Invoice Line Item Component Cost Data

## Structure

`InvoiceLineItemComponentCostData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Rates` | [`List<ComponentCostData>`](../../doc/models/component-cost-data.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

InvoiceLineItemComponentCostData invoiceLineItemComponentCostData = new InvoiceLineItemComponentCostData
{
    Rates = new List<ComponentCostData>
    {
        new ComponentCostData
        {
            ComponentCodeId = 116,
            PricePointId = 226,
            ProductId = 94,
            Quantity = "quantity0",
            Amount = "amount6",
        },
        new ComponentCostData
        {
            ComponentCodeId = 116,
            PricePointId = 226,
            ProductId = 94,
            Quantity = "quantity0",
            Amount = "amount6",
        },
    },
};
```

