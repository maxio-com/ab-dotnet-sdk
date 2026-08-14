
# Invoice Pre Payment

## Structure

`InvoicePrePayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int?` | Optional | The subscription id for the prepayment account |
| `AmountInCents` | `long?` | Optional | The amount in cents of the prepayment that was created as a result of this payment. |
| `EndingBalanceInCents` | `long?` | Optional | The total balance of the prepayment account for this subscription including any prior prepayments |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoicePrePayment invoicePrePayment = new InvoicePrePayment
{
    SubscriptionId = 252,
    AmountInCents = 28L,
    EndingBalanceInCents = 244L,
};
```

