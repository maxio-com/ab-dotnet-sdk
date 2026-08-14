
# Contract

Contract linked to the scheduled renewal configuration.

## Structure

`Contract`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `MaxioId` | `string` | Optional | - |
| `Number` | `string` | Optional | - |
| `Register` | [`Register`](../../doc/models/register.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Contract contract = new Contract
{
    Id = 112,
    MaxioId = "maxio_id6",
    Number = "number2",
    Register = new Register
    {
        Id = 54,
        MaxioId = "maxio_id4",
        Name = "name2",
        CurrencyCode = "currency_code2",
    },
};
```

