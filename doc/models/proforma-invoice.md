
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
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `DeliveryDate` | `DateTime?` | Optional | - |
| `Status` | [`ProformaInvoiceStatus?`](../../doc/models/proforma-invoice-status.md) | Optional | - |
| `CollectionMethod` | [`CollectionMethod?`](../../doc/models/collection-method.md) | Optional | The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`.<br>**Default**: `CollectionMethod.automatic` |
| `PaymentInstructions` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `ConsolidationLevel` | [`InvoiceConsolidationLevel?`](../../doc/models/invoice-consolidation-level.md) | Optional | Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:<br><br>* "none": A normal invoice with no consolidation.<br>* "child": An invoice segment which has been combined into a consolidated invoice.<br>* "parent": A consolidated invoice, whose contents are composed of invoice segments.<br><br>"Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.<br><br>See also the [invoice consolidation documentation](https://chargify.zendesk.com/hc/en-us/articles/4407746391835). |
| `ProductName` | `string` | Optional | - |
| `ProductFamilyName` | `string` | Optional | - |
| `Role` | [`ProformaInvoiceRole?`](../../doc/models/proforma-invoice-role.md) | Optional | 'proforma' value is deprecated in favor of proforma_adhoc and proforma_automatic |
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
| `CustomFields` | [`List<InvoiceCustomField>`](../../doc/models/invoice-custom-field.md) | Optional | - |
| `PublicUrl` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "collection_method": "automatic",
  "uid": "uid6",
  "site_id": 196,
  "customer_id": 52,
  "subscription_id": 124,
  "number": 0
}
```

