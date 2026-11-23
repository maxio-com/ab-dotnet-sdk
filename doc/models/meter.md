
# Meter

The metering meter this wallet is paired with, or `null` for a wallet with no meter. Set on create and immutable afterward.

## Structure

`Meter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `ConversionRate` | `string` | Optional | How many wallet units one meter unit is worth, as a decimal string. Defaults to `"1.0"`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Meter meter = new Meter
{
    Id = 198,
    Name = "name0",
    Handle = "handle6",
    ConversionRate = "conversion_rate2",
};
```

