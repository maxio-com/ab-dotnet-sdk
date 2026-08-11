
# Usage

## Structure

`Usage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | **Constraints**: `>= 0` |
| `Memo` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `Quantity` | [`UsageQuantity`](../../doc/models/containers/usage-quantity.md) | Optional | This is a container for one-of cases. |
| `OverageQuantity` | `int?` | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `ComponentHandle` | `string` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Globalization;

Usage usage = new Usage
{
    Id = 150L,
    Memo = "memo2",
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    PricePointId = 28,
    Quantity = UsageQuantity.FromNumber(28),
};
```

