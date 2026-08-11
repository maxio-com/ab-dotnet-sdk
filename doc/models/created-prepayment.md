
# Created Prepayment

## Structure

`CreatedPrepayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | **Constraints**: `>= 1` |
| `SubscriptionId` | `int?` | Optional | **Constraints**: `>= 1` |
| `AmountInCents` | `long?` | Optional | **Constraints**: `>= 0.01` |
| `Memo` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `StartingBalanceInCents` | `long?` | Optional | **Constraints**: `>= 0` |
| `EndingBalanceInCents` | `long?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

CreatedPrepayment createdPrepayment = new CreatedPrepayment
{
    Id = 186L,
    SubscriptionId = 40,
    AmountInCents = 240L,
    Memo = "memo6",
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

