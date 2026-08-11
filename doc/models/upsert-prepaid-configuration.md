
# Upsert Prepaid Configuration

## Structure

`UpsertPrepaidConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InitialFundingAmountInCents` | `long?` | Optional | - |
| `ReplenishToAmountInCents` | `long?` | Optional | - |
| `AutoReplenish` | `bool?` | Optional | - |
| `ReplenishThresholdAmountInCents` | `long?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpsertPrepaidConfiguration upsertPrepaidConfiguration = new UpsertPrepaidConfiguration
{
    InitialFundingAmountInCents = 244L,
    ReplenishToAmountInCents = 246L,
    AutoReplenish = false,
    ReplenishThresholdAmountInCents = 190L,
};
```

