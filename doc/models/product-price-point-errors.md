
# Product Price Point Errors

## Structure

`ProductPricePointErrors`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricePoint` | `string` | Optional | - |
| `Interval` | `List<string>` | Optional | - |
| `IntervalUnit` | `List<string>` | Optional | - |
| `Name` | `List<string>` | Optional | - |
| `Price` | `List<string>` | Optional | - |
| `PriceInCents` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ProductPricePointErrors productPricePointErrors = new ProductPricePointErrors
{
    PricePoint = "can't be blank",
    Interval = new List<string>
    {
        "Recurring Interval: cannot be blank.",
        "Recurring Interval: must be greater than or equal to 1.",
    },
    IntervalUnit = new List<string>
    {
        "Interval unit: cannot be blank.",
        "Interval unit: must be 'month' or 'day'.",
    },
    Name = new List<string>
    {
        "Name: cannot be blank.",
    },
    Price = new List<string>
    {
        "Price: is not a number.",
        "Price: must be greater than or equal to 0.",
    },
    PriceInCents = new List<string>
    {
        "Price in cents: cannot be blank.",
    },
};
```

