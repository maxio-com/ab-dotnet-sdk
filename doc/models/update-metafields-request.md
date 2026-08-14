
# Update Metafields Request

## Structure

`UpdateMetafieldsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metafields` | [`UpdateMetafieldsRequestMetafields`](../../doc/models/containers/update-metafields-request-metafields.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

UpdateMetafieldsRequest updateMetafieldsRequest = new UpdateMetafieldsRequest
{
    Metafields = UpdateMetafieldsRequestMetafields.FromUpdateMetafield(
        new UpdateMetafield
        {
            CurrentName = "current_name0",
            Name = "name6",
            Scope = new MetafieldScope
            {
                Csv = IncludeOption.Exclude,
                Invoices = IncludeOption.Exclude,
                Statements = IncludeOption.Exclude,
                Portal = IncludeOption.Exclude,
                PublicShow = IncludeOption.Exclude,
            },
            InputType = MetafieldInput.BalanceTracker,
            MEnum = new List<string>
            {
                "enum2",
            },
        }
    ),
};
```

