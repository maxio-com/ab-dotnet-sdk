
# Upsert Prepaid Configuration Request

## Structure

`UpsertPrepaidConfigurationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrepaidConfiguration` | [`UpsertPrepaidConfiguration`](../../doc/models/upsert-prepaid-configuration.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpsertPrepaidConfigurationRequest upsertPrepaidConfigurationRequest = new UpsertPrepaidConfigurationRequest
{
    PrepaidConfiguration = new UpsertPrepaidConfiguration
    {
        InitialFundingAmountInCents = 74L,
        ReplenishToAmountInCents = 76L,
        AutoReplenish = false,
        ReplenishThresholdAmountInCents = 20L,
    },
};
```

