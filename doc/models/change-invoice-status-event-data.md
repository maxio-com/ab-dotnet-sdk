
# Change Invoice Status Event Data

Example schema for an `change_invoice_status` event

## Structure

`ChangeInvoiceStatusEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GatewayTransId` | `string` | Optional | Identifier for the transaction within the payment gateway. |
| `Amount` | `string` | Optional | The monetary value associated with the linked payment, expressed in dollars. |
| `FromStatus` | [`InvoiceStatus`](../../doc/models/invoice-status.md) | Required | The status of the invoice before any changes occurred. See [Invoice Statuses](https://maxio.zendesk.com/hc/en-us/articles/24252287829645-Advanced-Billing-Invoices-Overview#invoice-statuses) for more. |
| `ToStatus` | [`InvoiceStatus`](../../doc/models/invoice-status.md) | Required | The updated status of the invoice after changes have been made. See [Invoice Statuses](https://maxio.zendesk.com/hc/en-us/articles/24252287829645-Advanced-Billing-Invoices-Overview#invoice-statuses) for more. |
| `ConsolidationLevel` | [`InvoiceConsolidationLevel?`](../../doc/models/invoice-consolidation-level.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ChangeInvoiceStatusEventData changeInvoiceStatusEventData = new ChangeInvoiceStatusEventData
{
    FromStatus = InvoiceStatus.Canceled,
    ToStatus = InvoiceStatus.Processing,
    GatewayTransId = "gateway_trans_id4",
    Amount = "amount6",
    ConsolidationLevel = InvoiceConsolidationLevel.Parent,
};
```

