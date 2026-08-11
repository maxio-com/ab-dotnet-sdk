
# Chjs Tokenization Failure

## Structure

`ChjsTokenizationFailure`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | `string` | Required | - |
| `PaymentProfileParams` | [`PaymentProfileParams`](../../doc/models/payment-profile-params.md) | Optional | PCI-safe cardholder fields only. Full card numbers, CVV, and billing address are never included. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ChjsTokenizationFailure chjsTokenizationFailure = new ChjsTokenizationFailure
{
    Errors = "errors2",
    PaymentProfileParams = new PaymentProfileParams
    {
        FirstName = "first_name2",
        LastName = "last_name0",
        CardType = "card_type2",
    },
};
```

