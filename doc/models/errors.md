
# Errors

## Structure

`Errors`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | `List<string>` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

Errors errors = new Errors
{
    PricePoint = new List<string>
    {
        "price_point0",
        "price_point9",
        "price_point8",
    },
};
```

