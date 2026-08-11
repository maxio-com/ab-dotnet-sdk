
# Service Credit

## Structure

`ServiceCredit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `AmountInCents` | `long?` | Optional | The amount in cents of the entry |
| `EndingBalanceInCents` | `long?` | Optional | The new balance for the credit account |
| `EntryType` | [`ServiceCreditType?`](../../doc/models/service-credit-type.md) | Optional | The type of entry |
| `Memo` | `string` | Optional | The memo attached to the entry |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ServiceCredit serviceCredit = new ServiceCredit
{
    Id = 132,
    AmountInCents = 218L,
    EndingBalanceInCents = 2L,
    EntryType = ServiceCreditType.Credit,
    Memo = "memo8",
};
```

