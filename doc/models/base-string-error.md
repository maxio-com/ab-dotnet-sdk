
# Base String Error

The error is base if it is not directly associated with a single attribute.

## Structure

`BaseStringError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Base` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

BaseStringError baseStringError = new BaseStringError
{
    MBase = new List<string>
    {
        "base5",
        "base6",
    },
};
```

