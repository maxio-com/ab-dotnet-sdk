
# Send Invoice Request

## Structure

`SendInvoiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RecipientEmails` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `5` |
| `CcRecipientEmails` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `5` |
| `BccRecipientEmails` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `5` |
| `AttachmentUrls` | `List<string>` | Optional | Array of URLs to files to attach to the invoice email. Max 10 files, 10MB each.<br><br>**Constraints**: *Maximum Items*: `10` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

SendInvoiceRequest sendInvoiceRequest = new SendInvoiceRequest
{
    RecipientEmails = new List<string>
    {
        "recipient_emails7",
    },
    CcRecipientEmails = new List<string>
    {
        "cc_recipient_emails2",
    },
    BccRecipientEmails = new List<string>
    {
        "bcc_recipient_emails0",
        "bcc_recipient_emails1",
        "bcc_recipient_emails2",
    },
    AttachmentUrls = new List<string>
    {
        "attachment_urls4",
    },
};
```

