
# Prepaid Configuration Response

## Structure

`PrepaidConfigurationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PrepaidConfiguration` | [`PrepaidConfiguration`](../../doc/models/prepaid-configuration.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PrepaidConfigurationResponse prepaidConfigurationResponse = new PrepaidConfigurationResponse
{
    PrepaidConfiguration = new PrepaidConfiguration
    {
        Id = 142,
        InitialFundingAmountInCents = 74L,
        ReplenishToAmountInCents = 76L,
        AutoReplenish = false,
        ReplenishThresholdAmountInCents = 20L,
    },
};
```

