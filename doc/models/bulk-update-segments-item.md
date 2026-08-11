
# Bulk Update Segments Item

## Structure

`BulkUpdateSegmentsItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | The ID of the segment you want to update. |
| `PricingScheme` | [`PricingScheme`](../../doc/models/pricing-scheme.md) | Required | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `Prices` | [`List<CreateOrUpdateSegmentPrice>`](../../doc/models/create-or-update-segment-price.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

BulkUpdateSegmentsItem bulkUpdateSegmentsItem = new BulkUpdateSegmentsItem
{
    Id = 220,
    PricingScheme = PricingScheme.PerUnit,
    Prices = new List<CreateOrUpdateSegmentPrice>
    {
        new CreateOrUpdateSegmentPrice
        {
            UnitPrice = CreateOrUpdateSegmentPriceUnitPrice.FromString("String3"),
            StartingQuantity = 64,
            EndingQuantity = 38,
        },
    },
};
```

