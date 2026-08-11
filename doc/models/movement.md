
# Movement

## Structure

`Movement`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Timestamp` | `DateTimeOffset?` | Optional | - |
| `AmountInCents` | `long?` | Optional | - |
| `AmountFormatted` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Category` | `string` | Optional | - |
| `Breakouts` | [`Breakouts`](../../doc/models/breakouts.md) | Optional | - |
| `LineItems` | [`List<MovementLineItem>`](../../doc/models/movement-line-item.md) | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `SubscriberName` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

Movement movement = new Movement
{
    Timestamp = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    AmountInCents = 34L,
    AmountFormatted = "amount_formatted6",
    Description = "description4",
    Category = "category2",
};
```

