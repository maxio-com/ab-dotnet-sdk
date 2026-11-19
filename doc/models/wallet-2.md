
# Wallet 2

## Structure

`Wallet2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A merchant-facing label for the wallet. Surrounding spaces are stripped; a blank or `null` value clears it.<br><br>**Constraints**: *Maximum Length*: `255` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Wallet2 wallet2 = new Wallet2
{
    Name = "name2",
};
```

