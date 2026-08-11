
# Create Payment Profile Request

## Structure

`CreatePaymentProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentProfile` | [`CreatePaymentProfile`](../../doc/models/create-payment-profile.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreatePaymentProfileRequest createPaymentProfileRequest = new CreatePaymentProfileRequest
{
    PaymentProfile = new CreatePaymentProfile
    {
        ChargifyToken = "tok_9g6hw85pnpt6knmskpwp4ttt",
        Id = 44,
        PaymentType = PaymentType.CreditCard,
        FirstName = "first_name4",
        LastName = "last_name2",
        FullNumber = "5424000000000015",
    },
};
```

