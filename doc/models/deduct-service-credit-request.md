
# Deduct Service Credit Request

## Structure

`DeductServiceCreditRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Deduction` | [`DeductServiceCredit`](../../doc/models/deduct-service-credit.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

DeductServiceCreditRequest deductServiceCreditRequest = new DeductServiceCreditRequest
{
    Deduction = new DeductServiceCredit
    {
        Amount = DeductServiceCreditAmount.FromString("String9"),
        Memo = "memo0",
    },
};
```

