
# Refund Prepayment

## Structure

`RefundPrepayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountInCents` | `long?` | Required | `amount` is not required if you pass `amount_in_cents`. |
| `Amount` | [`RefundPrepaymentAmount`](../../doc/models/containers/refund-prepayment-amount.md) | Required | This is a container for one-of cases. |
| `Memo` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `External` | `bool?` | Optional | Specify the type of refund you wish to initiate. When the prepayment is external, the `external` flag is optional. But if the prepayment was made through a payment profile, the `external` flag is required. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

RefundPrepayment refundPrepayment = new RefundPrepayment
{
    AmountInCents = 22L,
    Amount = RefundPrepaymentAmount.FromString("String1"),
    Memo = "memo2",
    External = false,
};
```

