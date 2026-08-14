
# Tax Configuration

## Structure

`TaxConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | [`TaxConfigurationKind?`](../../doc/models/tax-configuration-kind.md) | Optional | **Default**: `TaxConfigurationKind.custom` |
| `DestinationAddress` | [`TaxDestinationAddress?`](../../doc/models/tax-destination-address.md) | Optional | - |
| `FullyConfigured` | `bool?` | Optional | Returns `true` when Chargify has been properly configured to charge tax using the specified tax system. More details about taxes: https://maxio.zendesk.com/hc/en-us/articles/24287012608909-Taxes-Overview<br><br>**Default**: `false` |

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

