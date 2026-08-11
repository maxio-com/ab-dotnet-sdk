
# Errors

## Structure

`Errors`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PerPage` | `List<string>` | Optional | - |
| `PricePoint` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

Errors errors = new Errors
{
    PerPage = new List<string>
    {
        "per_page1",
        "per_page2",
        "per_page3",
    },
    PricePoint = new List<string>
    {
        "price_point0",
        "price_point9",
        "price_point8",
    },
};
```

