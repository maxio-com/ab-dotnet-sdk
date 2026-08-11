
# Renewal Preview Response

## Structure

`RenewalPreviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RenewalPreview` | [`RenewalPreview`](../../doc/models/renewal-preview.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

RenewalPreviewResponse renewalPreviewResponse = new RenewalPreviewResponse
{
    RenewalPreview = new RenewalPreview
    {
        NextAssessmentAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        SubtotalInCents = 132L,
        TotalTaxInCents = 0L,
        TotalDiscountInCents = 250L,
        TotalInCents = 20L,
    },
};
```

