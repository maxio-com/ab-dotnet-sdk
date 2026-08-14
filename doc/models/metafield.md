
# Metafield

## Structure

`Metafield`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Scope` | [`MetafieldScope`](../../doc/models/metafield-scope.md) | Optional | Warning: When updating a metafield's scope attribute, all scope attributes must be passed. Partially complete scope attributes will override the existing settings. |
| `DataCount` | `int?` | Optional | The amount of subscriptions this metafield has been applied to in Advanced Billing. |
| `InputType` | [`MetafieldInput?`](../../doc/models/metafield-input.md) | Optional | Indicates the type of metafield. A text metafield allows any string value. Dropdown and radio metafields have a set of values that can be selected. Defaults to 'text'. |
| `Enum` | [`MetafieldEnum`](../../doc/models/containers/metafield-enum.md) | Optional | This is a container for one-of cases. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Metafield metafield = new Metafield
{
    Id = 242,
    Name = "name4",
    Scope = new MetafieldScope
    {
        Csv = IncludeOption.Exclude,
        Invoices = IncludeOption.Exclude,
        Statements = IncludeOption.Exclude,
        Portal = IncludeOption.Exclude,
        PublicShow = IncludeOption.Exclude,
    },
    DataCount = 26,
    InputType = MetafieldInput.BalanceTracker,
};
```

