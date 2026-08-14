
# Update Payment Profile Request

## Structure

`UpdatePaymentProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentProfile` | [`UpdatePaymentProfile`](../../doc/models/update-payment-profile.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdatePaymentProfileRequest updatePaymentProfileRequest = new UpdatePaymentProfileRequest
{
    PaymentProfile = new UpdatePaymentProfile
    {
        FirstName = "first_name4",
        LastName = "last_name2",
        FullNumber = "5424000000000015",
        CardType = CardType.Bogus,
        ExpirationMonth = "expiration_month0",
    },
};
```

