
# Update Allocation Expiration Date

## Structure

`UpdateAllocationExpirationDate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Allocation` | [`AllocationExpirationDate`](../../doc/models/allocation-expiration-date.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

UpdateAllocationExpirationDate updateAllocationExpirationDate = new UpdateAllocationExpirationDate
{
    Allocation = new AllocationExpirationDate
    {
        ExpiresAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};
```

