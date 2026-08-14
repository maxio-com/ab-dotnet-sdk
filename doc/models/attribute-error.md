
# Attribute Error

## Structure

`AttributeError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Attribute` | `List<string>` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

AttributeError attributeError = new AttributeError
{
    Attribute = new List<string>
    {
        "attribute8",
        "attribute7",
    },
};
```

