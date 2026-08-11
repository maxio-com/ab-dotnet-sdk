
# Payment Related Events

## Structure

`PaymentRelatedEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductId` | `int` | Required | - |
| `AccountTransactionId` | `int` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentRelatedEvents paymentRelatedEvents = new PaymentRelatedEvents
{
    ProductId = 186,
    AccountTransactionId = 170,
};
```

