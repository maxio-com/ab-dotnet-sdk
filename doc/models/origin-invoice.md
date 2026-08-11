
# Origin Invoice

## Structure

`OriginInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | The UID of the invoice serving as an origin invoice. |
| `Number` | `string` | Optional | The number of the invoice serving as an origin invoice. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

OriginInvoice originInvoice = new OriginInvoice
{
    Uid = "uid8",
    Number = "number4",
};
```

