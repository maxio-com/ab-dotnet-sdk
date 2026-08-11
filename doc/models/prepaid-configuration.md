
# Prepaid Configuration

## Structure

`PrepaidConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `InitialFundingAmountInCents` | `long?` | Optional | - |
| `ReplenishToAmountInCents` | `long?` | Optional | - |
| `AutoReplenish` | `bool?` | Optional | - |
| `ReplenishThresholdAmountInCents` | `long?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PrepaidConfiguration prepaidConfiguration = new PrepaidConfiguration
{
    Id = 146,
    InitialFundingAmountInCents = 78L,
    ReplenishToAmountInCents = 80L,
    AutoReplenish = false,
    ReplenishThresholdAmountInCents = 232L,
};
```

