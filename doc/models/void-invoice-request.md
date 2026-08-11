
# Void Invoice Request

## Structure

`VoidInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Void` | [`VoidInvoice`](../../doc/models/void-invoice.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

VoidInvoiceRequest voidInvoiceRequest = new VoidInvoiceRequest
{
    MVoid = new VoidInvoice
    {
        Reason = "reason6",
    },
};
```

