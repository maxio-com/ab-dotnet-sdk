
# Allocation Preview Response

## Structure

`AllocationPreviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllocationPreview` | [`AllocationPreview`](../../doc/models/allocation-preview.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

AllocationPreviewResponse allocationPreviewResponse = new AllocationPreviewResponse
{
    AllocationPreview = new AllocationPreview
    {
        StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        EndDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        SubtotalInCents = 240L,
        TotalTaxInCents = 108L,
        TotalDiscountInCents = 142L,
    },
};
```

