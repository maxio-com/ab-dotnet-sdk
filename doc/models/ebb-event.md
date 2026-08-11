
# EBB Event

## Structure

`EBBEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Chargify` | [`ChargifyEBB`](../../doc/models/chargify-ebb.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

EBBEvent eBBEvent = new EBBEvent
{
    Chargify = new ChargifyEBB
    {
        Timestamp = DateTime.ParseExact("2020-02-27T17:45:50-05:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        SubscriptionId = 1,
    },
};
```

