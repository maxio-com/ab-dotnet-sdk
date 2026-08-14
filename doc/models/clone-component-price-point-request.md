
# Clone Component Price Point Request

## Structure

`CloneComponentPricePointRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | [`CloneComponentPricePoint`](../../doc/models/clone-component-price-point.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CloneComponentPricePointRequest cloneComponentPricePointRequest = new CloneComponentPricePointRequest
{
    PricePoint = new CloneComponentPricePoint
    {
        Name = "name0",
        Handle = "handle6",
    },
};
```

