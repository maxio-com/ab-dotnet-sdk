
# Proforma Invoice Issued

## Structure

`ProformaInvoiceIssued`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Required | - |
| `Number` | `string` | Required | - |
| `Role` | `string` | Required | - |
| `DeliveryDate` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `DueAmount` | `string` | Required | - |
| `PaidAmount` | `string` | Required | - |
| `TaxAmount` | `string` | Required | - |
| `TotalAmount` | `string` | Required | - |
| `ProductName` | `string` | Required | - |
| `LineItems` | [`List<InvoiceLineItemEventData>`](../../doc/models/invoice-line-item-event-data.md) | Required | - |

## Example (as JSON)

```json
{
  "uid": "uid0",
  "number": "number2",
  "role": "role6",
  "delivery_date": "delivery_date0",
  "created_at": "created_at8",
  "due_amount": "due_amount2",
  "paid_amount": "paid_amount8",
  "tax_amount": "tax_amount6",
  "total_amount": "total_amount6",
  "product_name": "product_name6",
  "line_items": [
    {
      "uid": "uid8",
      "title": "title4",
      "description": "description8",
      "quantity": 102,
      "quantity_delta": 204
    }
  ]
}
```

