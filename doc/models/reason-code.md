
# Reason Code

## Structure

`ReasonCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `SiteId` | `int?` | Optional | - |
| `Code` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Position` | `int?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ReasonCode reasonCode = new ReasonCode
{
    Id = 174,
    SiteId = 100,
    Code = "code4",
    Description = "description6",
    Position = 204,
};
```

