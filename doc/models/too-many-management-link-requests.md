
# Too Many Management Link Requests

## Structure

`TooManyManagementLinkRequests`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Required | - |
| `NewLinkAvailableAt` | `DateTimeOffset` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

TooManyManagementLinkRequests tooManyManagementLinkRequests = new TooManyManagementLinkRequests
{
    Error = "error8",
    NewLinkAvailableAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

