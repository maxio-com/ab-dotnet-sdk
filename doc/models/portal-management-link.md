
# Portal Management Link

## Structure

`PortalManagementLink`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | - |
| `FetchCount` | `int?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `NewLinkAvailableAt` | `DateTimeOffset?` | Optional | - |
| `ExpiresAt` | `DateTimeOffset?` | Optional | - |
| `LastInviteSentAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

PortalManagementLink portalManagementLink = new PortalManagementLink
{
    Url = "url8",
    FetchCount = 88,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    NewLinkAvailableAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

