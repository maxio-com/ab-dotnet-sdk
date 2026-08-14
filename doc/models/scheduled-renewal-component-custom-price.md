
# Scheduled Renewal Component Custom Price

Custom pricing for a component within a scheduled renewal.

## Structure

`ScheduledRenewalComponentCustomPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TaxIncluded` | `bool?` | Optional | Whether or not the price point includes tax |
| `PricingScheme` | [`PricingScheme`](../../doc/models/pricing-scheme.md) | Required | Omit for On/Off components. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Required | On/off components only need one price bracket starting at 1. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

ScheduledRenewalComponentCustomPrice scheduledRenewalComponentCustomPrice = new ScheduledRenewalComponentCustomPrice
{
    PricingScheme = PricingScheme.PerUnit,
    Prices = new List<Price>
    {
        new Price
        {
            StartingQuantity = PriceStartingQuantity.FromNumber(242),
            UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            EndingQuantity = PriceEndingQuantity.FromNumber(40),
        },
    },
    TaxIncluded = false,
};
```

