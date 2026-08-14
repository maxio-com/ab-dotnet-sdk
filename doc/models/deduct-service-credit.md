
# Deduct Service Credit

## Structure

`DeductServiceCredit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`DeductServiceCreditAmount`](../../doc/models/containers/deduct-service-credit-amount.md) | Required | This is a container for one-of cases. |
| `Memo` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

DeductServiceCredit deductServiceCredit = new DeductServiceCredit
{
    Amount = DeductServiceCreditAmount.FromString("String5"),
    Memo = "memo6",
};
```

