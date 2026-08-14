
# Resent Invitation

## Structure

`ResentInvitation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LastSentAt` | `string` | Optional | - |
| `LastAcceptedAt` | `string` | Optional | - |
| `SendInviteLinkText` | `string` | Optional | - |
| `UninvitedCount` | `int?` | Optional | - |
| `LastInviteSentAt` | `DateTimeOffset?` | Optional | - |
| `LastInviteAcceptedAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

ResentInvitation resentInvitation = new ResentInvitation
{
    LastSentAt = "last_sent_at0",
    LastAcceptedAt = "last_accepted_at0",
    SendInviteLinkText = "send_invite_link_text8",
    UninvitedCount = 178,
    LastInviteSentAt = DateTime.ParseExact("2024-01-01T04:30:00+00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LastInviteAcceptedAt = DateTime.ParseExact("2024-01-01T04:35:00+00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

