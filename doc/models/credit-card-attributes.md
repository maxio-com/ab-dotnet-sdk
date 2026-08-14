
# Credit Card Attributes

## Structure

`CreditCardAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FullNumber` | `string` | Optional | - |
| `ExpirationMonth` | `string` | Optional | - |
| `ExpirationYear` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreditCardAttributes creditCardAttributes = new CreditCardAttributes
{
    FullNumber = "full_number8",
    ExpirationMonth = "expiration_month8",
    ExpirationYear = "expiration_year2",
};
```

