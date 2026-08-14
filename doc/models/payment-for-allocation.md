
# Payment for Allocation

Information for captured payment, if applicable

## Structure

`PaymentForAllocation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `AmountInCents` | `long?` | Optional | - |
| `Success` | `bool?` | Optional | - |
| `Memo` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentForAllocation paymentForAllocation = new PaymentForAllocation
{
    Id = 68,
    AmountInCents = 102L,
    Success = false,
    Memo = "memo6",
};
```

