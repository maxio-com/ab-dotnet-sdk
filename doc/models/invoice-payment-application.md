
# Invoice Payment Application

## Structure

`InvoicePaymentApplication`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InvoiceUid` | `string` | Optional | Unique identifier for the paid invoice. It has the prefix "inv_" followed by alphanumeric characters. |
| `ApplicationUid` | `string` | Optional | Unique identifier for the payment. It has the prefix "pmt_" followed by alphanumeric characters. |
| `AppliedAmount` | `string` | Optional | Dollar amount of the paid invoice. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoicePaymentApplication invoicePaymentApplication = new InvoicePaymentApplication
{
    InvoiceUid = "invoice_uid8",
    ApplicationUid = "application_uid8",
    AppliedAmount = "applied_amount0",
};
```

