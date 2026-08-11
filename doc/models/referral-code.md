
# Referral Code

## Structure

`ReferralCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `SiteId` | `int?` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `Code` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ReferralCode referralCode = new ReferralCode
{
    Id = 186,
    SiteId = 112,
    SubscriptionId = 40,
    Code = "code6",
};
```

