
# Invoice Refund

## Structure

`InvoiceRefund`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionId` | `int?` | Optional | - |
| `PaymentId` | `int?` | Optional | - |
| `Memo` | `string` | Optional | - |
| `OriginalAmount` | `string` | Optional | - |
| `AppliedAmount` | `string` | Optional | - |
| `GatewayTransactionId` | `string` | Optional | The transaction ID for the refund as returned from the payment gateway |
| `GatewayUsed` | `string` | Optional | - |
| `GatewayHandle` | `string` | Optional | - |
| `AchLateReject` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceRefund invoiceRefund = new InvoiceRefund
{
    TransactionId = 166,
    PaymentId = 36,
    Memo = "memo6",
    OriginalAmount = "original_amount6",
    AppliedAmount = "applied_amount6",
};
```

