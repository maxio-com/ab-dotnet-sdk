
# List Metafields Response

## Structure

`ListMetafieldsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalCount` | `int?` | Optional | - |
| `CurrentPage` | `int?` | Optional | - |
| `TotalPages` | `int?` | Optional | - |
| `PerPage` | `int?` | Optional | - |
| `Metafields` | [`List<Metafield>`](../../doc/models/metafield.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListMetafieldsResponse listMetafieldsResponse = new ListMetafieldsResponse
{
    TotalCount = 228,
    CurrentPage = 204,
    TotalPages = 216,
    PerPage = 74,
    Metafields = new List<Metafield>
    {
        new Metafield
        {
            Id = 22,
            Name = "name2",
            Scope = new MetafieldScope
            {
                Csv = IncludeOption.Exclude,
                Invoices = IncludeOption.Exclude,
                Statements = IncludeOption.Exclude,
                Portal = IncludeOption.Exclude,
                PublicShow = IncludeOption.Exclude,
            },
            DataCount = 10,
            InputType = MetafieldInput.BalanceTracker,
        },
        new Metafield
        {
            Id = 22,
            Name = "name2",
            Scope = new MetafieldScope
            {
                Csv = IncludeOption.Exclude,
                Invoices = IncludeOption.Exclude,
                Statements = IncludeOption.Exclude,
                Portal = IncludeOption.Exclude,
                PublicShow = IncludeOption.Exclude,
            },
            DataCount = 10,
            InputType = MetafieldInput.BalanceTracker,
        },
        new Metafield
        {
            Id = 22,
            Name = "name2",
            Scope = new MetafieldScope
            {
                Csv = IncludeOption.Exclude,
                Invoices = IncludeOption.Exclude,
                Statements = IncludeOption.Exclude,
                Portal = IncludeOption.Exclude,
                PublicShow = IncludeOption.Exclude,
            },
            DataCount = 10,
            InputType = MetafieldInput.BalanceTracker,
        },
    },
};
```

