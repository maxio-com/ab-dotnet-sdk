
# Service Credit Response

## Structure

`ServiceCreditResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceCredit` | [`ServiceCredit`](../../doc/models/service-credit.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ServiceCreditResponse serviceCreditResponse = new ServiceCreditResponse
{
    ServiceCredit = new ServiceCredit
    {
        Id = 38,
        AmountInCents = 124L,
        EndingBalanceInCents = 164L,
        EntryType = ServiceCreditType.Credit,
        Memo = "memo0",
    },
};
```

