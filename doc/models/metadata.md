
# Metadata

## Structure

`Metadata`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `MValue` | `string` | Optional | - |
| `ResourceId` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `DeletedAt` | `DateTimeOffset?` | Optional | - |
| `MetafieldId` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

Metadata metadata = new Metadata
{
    Id = 50,
    MValue = "value8",
    ResourceId = 134,
    Name = "name6",
    DeletedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

