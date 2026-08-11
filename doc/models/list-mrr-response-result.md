
# List MRR Response Result

## Structure

`ListMRRResponseResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Page` | `int?` | Optional | - |
| `PerPage` | `int?` | Optional | - |
| `TotalPages` | `int?` | Optional | - |
| `TotalEntries` | `int?` | Optional | - |
| `Currency` | `string` | Optional | - |
| `CurrencySymbol` | `string` | Optional | - |
| `Movements` | [`List<Movement>`](../../doc/models/movement.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListMRRResponseResult listMRRResponseResult = new ListMRRResponseResult
{
    Page = 40,
    PerPage = 208,
    TotalPages = 82,
    TotalEntries = 78,
    Currency = "currency6",
};
```

