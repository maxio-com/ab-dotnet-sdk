
# Create Prepayment Request

## Structure

`CreatePrepaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prepayment` | [`CreatePrepayment`](../../doc/models/create-prepayment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreatePrepaymentRequest createPrepaymentRequest = new CreatePrepaymentRequest
{
    Prepayment = new CreatePrepayment
    {
        Amount = 11.6,
        Details = "details8",
        Memo = "memo2",
        Method = CreatePrepaymentMethod.MoneyOrder,
        PaymentProfileId = 240,
    },
};
```

