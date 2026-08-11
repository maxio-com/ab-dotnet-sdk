
# Invoice Payment Method

## Structure

`InvoicePaymentMethod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Details` | `string` | Optional | - |
| `Kind` | `string` | Optional | - |
| `Memo` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `CardBrand` | `string` | Optional | - |
| `CardExpiration` | `string` | Optional | - |
| `LastFour` | `string` | Optional | - |
| `MaskedCardNumber` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoicePaymentMethod invoicePaymentMethod = new InvoicePaymentMethod
{
    Details = "details2",
    Kind = "kind0",
    Memo = "memo6",
    Type = "type8",
    CardBrand = "card_brand4",
};
```

