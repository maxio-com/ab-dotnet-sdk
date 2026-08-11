
# Agreement Acceptance

Required when creating a subscription with Maxio Payments.

## Structure

`AgreementAcceptance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IpAddress` | `string` | Optional | Required when providing agreement acceptance params. |
| `TermsUrl` | `string` | Optional | Required when creating a subscription with Maxio Payments. Either terms_url or privacy_policy_url is required when providing agreement_acceptance params. |
| `PrivacyPolicyUrl` | `string` | Optional | - |
| `ReturnRefundPolicyUrl` | `string` | Optional | - |
| `DeliveryPolicyUrl` | `string` | Optional | - |
| `SecureCheckoutPolicyUrl` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

AgreementAcceptance agreementAcceptance = new AgreementAcceptance
{
    IpAddress = "ip_address8",
    TermsUrl = "terms_url6",
    PrivacyPolicyUrl = "privacy_policy_url4",
    ReturnRefundPolicyUrl = "return_refund_policy_url0",
    DeliveryPolicyUrl = "delivery_policy_url4",
};
```

