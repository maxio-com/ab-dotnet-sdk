
# Allocation Preview

## Structure

`AllocationPreview`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `DateTimeOffset?` | Optional | - |
| `EndDate` | `DateTimeOffset?` | Optional | - |
| `SubtotalInCents` | `long?` | Optional | - |
| `TotalTaxInCents` | `long?` | Optional | - |
| `TotalDiscountInCents` | `long?` | Optional | - |
| `TotalInCents` | `long?` | Optional | - |
| `Direction` | [`AllocationPreviewDirection?`](../../doc/models/allocation-preview-direction.md) | Optional | - |
| `ProrationScheme` | `string` | Optional | - |
| `LineItems` | [`List<AllocationPreviewLineItem>`](../../doc/models/allocation-preview-line-item.md) | Optional | - |
| `AccrueCharge` | `bool?` | Optional | - |
| `Allocations` | [`List<AllocationPreviewItem>`](../../doc/models/allocation-preview-item.md) | Optional | - |
| `PeriodType` | `string` | Optional | - |
| `ExistingBalanceInCents` | `long?` | Optional | An integer representing the amount of the subscription's current balance |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

AllocationPreview allocationPreview = new AllocationPreview
{
    StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    EndDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    SubtotalInCents = 140L,
    TotalTaxInCents = 8L,
    TotalDiscountInCents = 242L,
};
```

