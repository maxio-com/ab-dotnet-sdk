
# Revoked Invitation

## Structure

`RevokedInvitation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LastSentAt` | `string` | Optional | - |
| `LastAcceptedAt` | `string` | Optional | - |
| `UninvitedCount` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

RevokedInvitation revokedInvitation = new RevokedInvitation
{
    LastSentAt = "last_sent_at8",
    LastAcceptedAt = "last_accepted_at8",
    UninvitedCount = 130,
};
```

