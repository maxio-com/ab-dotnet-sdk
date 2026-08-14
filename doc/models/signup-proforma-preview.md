
# Signup Proforma Preview

## Structure

`SignupProformaPreview`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrentProformaInvoice` | [`ProformaInvoice`](../../doc/models/proforma-invoice.md) | Optional | - |
| `NextProformaInvoice` | [`ProformaInvoice`](../../doc/models/proforma-invoice.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SignupProformaPreview signupProformaPreview = new SignupProformaPreview
{
    CurrentProformaInvoice = new ProformaInvoice
    {
        Uid = "uid6",
        SiteId = 72,
        CustomerId = 184,
        SubscriptionId = 0,
        Number = 132,
    },
    NextProformaInvoice = new ProformaInvoice
    {
        Uid = "uid8",
        SiteId = 212,
        CustomerId = 68,
        SubscriptionId = 140,
        Number = 16,
    },
};
```

