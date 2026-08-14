
# Auto Resume

## Structure

`AutoResume`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutomaticallyResumeAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

AutoResume autoResume = new AutoResume
{
    AutomaticallyResumeAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

