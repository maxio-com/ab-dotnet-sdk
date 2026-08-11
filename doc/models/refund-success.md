
# Refund Success

## Structure

`RefundSuccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RefundId` | `int` | Required | - |
| `GatewayTransactionId` | `int` | Required | - |
| `ProductId` | `int` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

RefundSuccess refundSuccess = new RefundSuccess
{
    RefundId = 34,
    GatewayTransactionId = 160,
    ProductId = 190,
};
```

