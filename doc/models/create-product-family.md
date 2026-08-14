
# Create Product Family

## Structure

`CreateProductFamily`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Handle` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Surcharging` | `bool?` | Optional | Whether surcharging applies to this product family. Defaults to `true` when omitted. Only applied on sites where surcharging is enabled. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateProductFamily createProductFamily = new CreateProductFamily
{
    Name = "name0",
    Handle = "handle6",
    Description = "description0",
    Surcharging = false,
};
```

