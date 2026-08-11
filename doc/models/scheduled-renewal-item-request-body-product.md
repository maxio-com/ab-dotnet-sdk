
# Scheduled Renewal Item Request Body Product

## Structure

`ScheduledRenewalItemRequestBodyProduct`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ItemType` | `string` | Required, Constant | Item type to add. Either Product or Component.<br><br>**Value**: `"Product"` |
| `ItemId` | `int` | Required | Product or component identifier. |
| `PricePointId` | `int?` | Optional | Price point identifier. |
| `Quantity` | `int?` | Optional | (Optional) Quantity for the item. |
| `CustomPrice` | [`ScheduledRenewalProductPricePoint`](../../doc/models/scheduled-renewal-product-price-point.md) | Optional | Custom pricing for a product within a scheduled renewal. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

ScheduledRenewalItemRequestBodyProduct scheduledRenewalItemRequestBodyProduct = new ScheduledRenewalItemRequestBodyProduct
{
    ItemType = "Product",
    ItemId = 154,
    PricePointId = 168,
    Quantity = 166,
    CustomPrice = new ScheduledRenewalProductPricePoint
    {
        PriceInCents = ScheduledRenewalProductPricePointPriceInCents.FromString("String3"),
        Interval = ScheduledRenewalProductPricePointInterval.FromString("String3"),
        IntervalUnit = IntervalUnit.Day,
        Name = "name4",
        Handle = "handle0",
        TaxIncluded = false,
        InitialChargeInCents = 30L,
        ExpirationInterval = 52,
    },
};
```

