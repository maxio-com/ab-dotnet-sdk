
# Payer Error

## Structure

`PayerError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LastName` | `List<string>` | Optional | - |
| `FirstName` | `List<string>` | Optional | - |
| `Email` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

PayerError payerError = new PayerError
{
    LastName = new List<string>
    {
        "last_name9",
    },
    FirstName = new List<string>
    {
        "first_name2",
        "first_name3",
        "first_name4",
    },
    Email = new List<string>
    {
        "email6",
        "email7",
        "email8",
    },
};
```

