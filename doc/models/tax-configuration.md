
# Tax Configuration

## Structure

`TaxConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | [`TaxConfigurationKind?`](../../doc/models/tax-configuration-kind.md) | Optional | **Default**: `TaxConfigurationKind.custom` |
| `DestinationAddress` | [`TaxDestinationAddress?`](../../doc/models/tax-destination-address.md) | Optional | - |
| `FullyConfigured` | `bool?` | Optional | Returns `true` when Chargify has been properly configured to charge tax using the specified tax system. More details about taxes: https://docs.maxio.com/billing/taxes/overview/understand-tax-options<br><br>**Default**: `false` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

TaxConfiguration taxConfiguration = new TaxConfiguration
{
    Kind = TaxConfigurationKind.Custom,
    DestinationAddress = TaxDestinationAddress.ShippingOnly,
    FullyConfigured = false,
};
```

