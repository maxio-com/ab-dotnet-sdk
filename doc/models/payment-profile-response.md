
# Payment Profile Response

## Structure

`PaymentProfileResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentProfile` | [`PaymentProfile`](../../doc/models/containers/payment-profile.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

PaymentProfileResponse paymentProfileResponse = new PaymentProfileResponse
{
    PaymentProfile = PaymentProfile.FromApplePayPaymentProfile(
        new ApplePayPaymentProfile
        {
            PaymentType = PaymentType.ApplePay,
            Id = 60,
            FirstName = "first_name2",
            LastName = "last_name0",
            CustomerId = 98,
            CurrentVault = ApplePayVault.BraintreeBlue,
        }
    ),
};
```

