
# Void Invoice

## Structure

`VoidInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

VoidInvoice voidInvoice = new VoidInvoice
{
    Reason = "reason8",
};
```

