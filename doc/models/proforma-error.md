
# Proforma Error

## Structure

`ProformaError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subscription` | [`BaseStringError`](../../doc/models/base-string-error.md) | Optional | The error is base if it is not directly associated with a single attribute. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ProformaError proformaError = new ProformaError
{
    Subscription = new BaseStringError
    {
        MBase = new List<string>
        {
            "base3",
            "base4",
        },
    },
};
```

