
# Create Invoice

## Structure

`CreateInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LineItems` | [`List<CreateInvoiceItem>`](../../doc/models/create-invoice-item.md) | Optional | - |
| `IssueDate` | `string` | Optional | - |
| `NetTerms` | `int?` | Optional | By default, invoices will be created with a due date matching the date of invoice creation. If a different due date is desired, the net_terms parameter can be sent indicating the number of days in advance the due date should be. |
| `PaymentInstructions` | `string` | Optional | - |
| `Memo` | `string` | Optional | A custom memo can be sent to override the site's default. |
| `SellerAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Overrides the defaults for the site |
| `BillingAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Overrides the default for the customer |
| `ShippingAddress` | [`CreateInvoiceAddress`](../../doc/models/create-invoice-address.md) | Optional | Overrides the default for the customer |
| `Coupons` | [`List<CreateInvoiceCoupon>`](../../doc/models/create-invoice-coupon.md) | Optional | - |
| `Status` | [`Status1?`](../../doc/models/status-1.md) | Optional | **Default**: `Status1.open` |

## Example (as JSON)

```json
{
  "status": "draft",
  "line_items": [
    {
      "title": "title4",
      "quantity": 56.68,
      "unit_price": 39.9,
      "taxable": false,
      "tax_code": "tax_code6"
    }
  ],
  "issue_date": "issue_date2",
  "net_terms": 18,
  "payment_instructions": "payment_instructions0",
  "memo": "memo6"
}
```

