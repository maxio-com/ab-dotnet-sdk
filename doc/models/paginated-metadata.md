
# Paginated Metadata

## Structure

`PaginatedMetadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalCount` | `int?` | Optional | - |
| `CurrentPage` | `int?` | Optional | - |
| `TotalPages` | `int?` | Optional | - |
| `PerPage` | `int?` | Optional | - |
| `Metadata` | [`List<Metadata>`](../../doc/models/metadata.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

PaginatedMetadata paginatedMetadata = new PaginatedMetadata
{
    TotalCount = 166,
    CurrentPage = 142,
    TotalPages = 154,
    PerPage = 136,
    Metadata = new List<Metadata>
    {
        new Metadata
        {
            Id = 50,
            MValue = "value8",
            ResourceId = 134,
            Name = "name6",
            DeletedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    },
};
```

