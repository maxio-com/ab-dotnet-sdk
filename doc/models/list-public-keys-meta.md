
# List Public Keys Meta

## Structure

`ListPublicKeysMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalCount` | `int?` | Optional | - |
| `CurrentPage` | `int?` | Optional | - |
| `TotalPages` | `int?` | Optional | - |
| `PerPage` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListPublicKeysMeta listPublicKeysMeta = new ListPublicKeysMeta
{
    TotalCount = 232,
    CurrentPage = 208,
    TotalPages = 220,
    PerPage = 70,
};
```

