
# Proration

## Structure

`Proration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreservePeriod` | `bool?` | Optional | The alternative to sending preserve_period as a direct attribute to migration |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Proration proration = new Proration
{
    PreservePeriod = false,
};
```

