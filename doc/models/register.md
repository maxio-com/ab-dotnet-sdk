
# Register

## Structure

`Register`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `MaxioId` | `string` | Optional | - |
| `Name` | `string` | Optional | - |
| `CurrencyCode` | `string` | Optional | The ISO 4217 currency code (3 character string) representing the currency of an invoice transaction. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Register register = new Register
{
    Id = 54,
    MaxioId = "maxio_id4",
    Name = "name2",
    CurrencyCode = "currency_code2",
};
```

