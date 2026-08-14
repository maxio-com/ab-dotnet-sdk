
# Deliver Proforma Invoice Request

## Structure

`DeliverProformaInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RecipientEmails` | `List<string>` | Optional | - |
| `CcRecipientEmails` | `List<string>` | Optional | - |
| `BccRecipientEmails` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

DeliverProformaInvoiceRequest deliverProformaInvoiceRequest = new DeliverProformaInvoiceRequest
{
    RecipientEmails = new List<string>
    {
        "recipient_emails3",
        "recipient_emails4",
    },
    CcRecipientEmails = new List<string>
    {
        "cc_recipient_emails2",
        "cc_recipient_emails1",
        "cc_recipient_emails0",
    },
    BccRecipientEmails = new List<string>
    {
        "bcc_recipient_emails6",
    },
};
```

