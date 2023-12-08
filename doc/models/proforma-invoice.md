
# Proforma Invoice

## Structure

`ProformaInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `SiteId` | `int?` | Optional | - |
| `CustomerId` | `int?` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |
| `Number` | `int?` | Optional | - |
| `SequenceNumber` | `int?` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `DeliveryDate` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `CollectionMethod` | `string` | Optional | - |
| `PaymentInstructions` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `ConsolidationLevel` | `string` | Optional | - |
| `ProductName` | `string` | Optional | - |
| `ProductFamilyName` | `string` | Optional | - |
| `Role` | `string` | Optional | - |
| `Seller` | [`InvoiceSeller`](../../doc/models/invoice-seller.md) | Optional | Information about the seller (merchant) listed on the masthead of the invoice. |
| `Customer` | [`InvoiceCustomer`](../../doc/models/invoice-customer.md) | Optional | Information about the customer who is owner or recipient the invoiced subscription. |
| `Memo` | `string` | Optional | - |
| `BillingAddress` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Optional | - |
| `ShippingAddress` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Optional | - |
| `SubtotalAmount` | `string` | Optional | - |
| `DiscountAmount` | `string` | Optional | - |
| `TaxAmount` | `string` | Optional | - |
| `TotalAmount` | `string` | Optional | - |
| `CreditAmount` | `string` | Optional | - |
| `PaidAmount` | `string` | Optional | - |
| `RefundAmount` | `string` | Optional | - |
| `DueAmount` | `string` | Optional | - |
| `LineItems` | [`List<InvoiceLineItem>`](../../doc/models/invoice-line-item.md) | Optional | - |
| `Discounts` | [`List<ProformaInvoiceDiscount>`](../../doc/models/proforma-invoice-discount.md) | Optional | - |
| `Taxes` | [`List<ProformaInvoiceTax>`](../../doc/models/proforma-invoice-tax.md) | Optional | - |
| `Credits` | [`List<ProformaInvoiceCredit>`](../../doc/models/proforma-invoice-credit.md) | Optional | - |
| `Payments` | [`List<ProformaInvoicePayment>`](../../doc/models/proforma-invoice-payment.md) | Optional | - |
| `CustomFields` | [`List<ProformaCustomField>`](../../doc/models/proforma-custom-field.md) | Optional | - |
| `PublicUrl` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "uid": "uid6",
  "site_id": 196,
  "customer_id": 52,
  "subscription_id": 124,
  "number": 0
}
```

