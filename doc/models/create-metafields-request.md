
# Create Metafields Request

## Structure

`CreateMetafieldsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metafields` | [`CreateMetafieldsRequestMetafields`](../../doc/models/containers/create-metafields-request-metafields.md) | Required | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

CreateMetafieldsRequest createMetafieldsRequest = new CreateMetafieldsRequest
{
    Metafields = CreateMetafieldsRequestMetafields.FromCreateMetafield(
        new CreateMetafield
        {
            Name = "my_field",
            Scope = new MetafieldScope
            {
                Csv = IncludeOption.Exclude,
                Invoices = IncludeOption.Exclude,
                Statements = IncludeOption.Exclude,
                Portal = IncludeOption.Exclude,
                PublicShow = IncludeOption.Exclude,
                PublicEdit = IncludeOption.Exclude,
            },
            InputType = MetafieldInput.Text,
            MEnum = new List<string>
            {
                "string",
            },
        }
    ),
};
```

