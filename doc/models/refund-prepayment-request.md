
# Refund Prepayment Request

## Structure

`RefundPrepaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Refund` | [`RefundPrepayment`](../../doc/models/refund-prepayment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

RefundPrepaymentRequest refundPrepaymentRequest = new RefundPrepaymentRequest
{
    Refund = new RefundPrepayment
    {
        AmountInCents = 132L,
        Amount = RefundPrepaymentAmount.FromString("String1"),
        Memo = "memo2",
        External = false,
    },
};
```

