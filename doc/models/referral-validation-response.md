
# Referral Validation Response

## Structure

`ReferralValidationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReferralCode` | [`ReferralCode`](../../doc/models/referral-code.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ReferralValidationResponse referralValidationResponse = new ReferralValidationResponse
{
    ReferralCode = new ReferralCode
    {
        Id = 46,
        SiteId = 228,
        SubscriptionId = 156,
        Code = "code0",
    },
};
```

