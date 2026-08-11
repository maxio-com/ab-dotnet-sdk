
# Create Metafield

## Structure

`CreateMetafield`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Scope` | [`MetafieldScope`](../../doc/models/metafield-scope.md) | Optional | Warning: When updating a metafield's scope attribute, all scope attributes must be passed. Partially complete scope attributes will override the existing settings. |
| `InputType` | [`MetafieldInput?`](../../doc/models/metafield-input.md) | Optional | Indicates the type of metafield. A text metafield allows any string value. Dropdown and radio metafields have a set of values that can be selected. Defaults to 'text'. |
| `Enum` | `List<string>` | Optional | Only applicable when input_type is radio or dropdown. Empty strings will not be submitted. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateMetafield createMetafield = new CreateMetafield
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
};
```

