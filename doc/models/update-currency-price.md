
# Update Currency Price

## Structure

`UpdateCurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | ID of the currency price record being updated |
| `Price` | `double` | Required | New price for the given currency |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateCurrencyPrice updateCurrencyPrice = new UpdateCurrencyPrice
{
    Id = 104,
    Price = 163.6,
};
```

