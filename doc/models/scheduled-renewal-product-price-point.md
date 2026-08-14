
# Scheduled Renewal Product Price Point

Custom pricing for a product within a scheduled renewal.

## Structure

`ScheduledRenewalProductPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | (Optional) |
| `Handle` | `string` | Optional | (Optional) |
| `PriceInCents` | [`ScheduledRenewalProductPricePointPriceInCents`](../../doc/models/containers/scheduled-renewal-product-price-point-price-in-cents.md) | Required | This is a container for one-of cases. |
| `Interval` | [`ScheduledRenewalProductPricePointInterval`](../../doc/models/containers/scheduled-renewal-product-price-point-interval.md) | Required | This is a container for one-of cases. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Required | Required if using `custom_price` attribute. |
| `TaxIncluded` | `bool?` | Optional | (Optional) |
| `InitialChargeInCents` | `long?` | Optional | The product price point initial charge, in integer cents. |
| `ExpirationInterval` | `int?` | Optional | The numerical expiration interval. e.g., an expiration_interval of ‘30’ coupled with an expiration_interval_unit of day would mean this product price point would expire after 30 days. |
| `ExpirationIntervalUnit` | [`ExpirationIntervalUnit?`](../../doc/models/expiration-interval-unit.md) | Optional | A string representing the expiration interval unit for this product price point, either month, day or never |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

ScheduledRenewalProductPricePoint scheduledRenewalProductPricePoint = new ScheduledRenewalProductPricePoint
{
    PriceInCents = ScheduledRenewalProductPricePointPriceInCents.FromString("String1"),
    Interval = ScheduledRenewalProductPricePointInterval.FromString("String7"),
    IntervalUnit = IntervalUnit.Day,
    Name = "name6",
    Handle = "handle2",
    TaxIncluded = false,
    InitialChargeInCents = 218L,
    ExpirationInterval = 240,
};
```

