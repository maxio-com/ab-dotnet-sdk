
# Payment Profile Params

PCI-safe cardholder fields only. Full card numbers, CVV, and billing address are never included.

## Structure

`PaymentProfileParams`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `CardType` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentProfileParams paymentProfileParams = new PaymentProfileParams
{
    FirstName = "first_name2",
    LastName = "last_name0",
    CardType = "card_type2",
};
```

