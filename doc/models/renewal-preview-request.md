
# Renewal Preview Request

## Structure

`RenewalPreviewRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Components` | [`List<RenewalPreviewComponent>`](../../doc/models/renewal-preview-component.md) | Optional | (Optional) Array of component definitions to preview. Providing any component definitions here will override the actual components on the subscription (and their quantities), and the billing preview will contain only these components (in addition to any product base fees). |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

RenewalPreviewRequest renewalPreviewRequest = new RenewalPreviewRequest
{
    Components = new List<RenewalPreviewComponent>
    {
        new RenewalPreviewComponent
        {
            ComponentId = RenewalPreviewComponentComponentId.FromString("String5"),
            Quantity = 210,
            PricePointId = RenewalPreviewComponentPricePointId.FromString("String3"),
        },
    },
};
```

