
# Errors 1

## Structure

`Errors1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PerPage` | `List<string>` | Optional | - |
| `PricePoint` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

Errors1 errors1 = new Errors1
{
    PerPage = new List<string>
    {
        "per_page9",
    },
    PricePoint = new List<string>
    {
        "price_point0",
    },
};
```

