
# Invoice Previous Balance

## Structure

`InvoicePreviousBalance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CaptureDate` | `string` | Optional | - |
| `Invoices` | [`List<InvoiceBalanceItem>`](../../doc/models/invoice-balance-item.md) | Optional | - |

## Example (as JSON)

```json
{
  "capture_date": "capture_date2",
  "invoices": [
    {
      "uid": "uid6",
      "number": "number6",
      "outstanding_amount": "outstanding_amount8"
    }
  ]
}
```

