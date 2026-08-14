
# Refund Prepayment Base Refund Error

## Structure

`RefundPrepaymentBaseRefundError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Refund` | [`BaseRefundError`](../../doc/models/base-refund-error.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Utilities;
using System.Collections.Generic;

RefundPrepaymentBaseRefundError refundPrepaymentBaseRefundError = new RefundPrepaymentBaseRefundError
{
    Refund = new BaseRefundError
    {
        MBase = new List<object>
        {
            ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
};
```

