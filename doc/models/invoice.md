
# Invoice

## Structure

`Invoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long?` | Optional | - |
| `Uid` | `string` | Optional | Unique identifier for the invoice. It is generated automatically by Chargify and has the prefix "inv_" followed by alphanumeric characters. |
| `SiteId` | `int?` | Optional | ID of the site to which the invoice belongs. |
| `CustomerId` | `int?` | Optional | ID of the customer to which the invoice belongs. |
| `SubscriptionId` | `int?` | Optional | ID of the subscription that generated the invoice. |
| `Number` | `string` | Optional | A unique, identifying string that appears on the invoice and in places the invoice is referenced.<br><br>While the UID is long and not appropriate to show to customers, the number is usually shorter and consumable by the customer and the merchant alike. |
| `SequenceNumber` | `int?` | Optional | A monotonically increasing number assigned to invoices as they are created.  This number is unique within a site and can be used to sort and order invoices. |
| `TransactionTime` | `DateTimeOffset?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `IssueDate` | `DateTime?` | Optional | Date the invoice was issued to the customer.  This is the date that the invoice was made available for payment.<br><br>The format is `"YYYY-MM-DD"`. |
| `DueDate` | `DateTime?` | Optional | Date the invoice is due.<br><br>The format is `"YYYY-MM-DD"`. |
| `PaidDate` | `DateTime?` | Optional | Date the invoice became fully paid.<br><br>If partial payments are applied to the invoice, this date will not be present until payment has been made in full.<br><br>The format is `"YYYY-MM-DD"`. |
| `Status` | [`InvoiceStatus?`](../../doc/models/invoice-status.md) | Optional | The current status of the invoice. See [Invoice Statuses](https://maxio.zendesk.com/hc/en-us/articles/24252287829645-Advanced-Billing-Invoices-Overview#invoice-statuses) for more. |
| `Role` | [`InvoiceRole?`](../../doc/models/invoice-role.md) | Optional | - |
| `ParentInvoiceId` | `int?` | Optional | - |
| `CollectionMethod` | [`CollectionMethod?`](../../doc/models/collection-method.md) | Optional | The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`. |
| `PaymentInstructions` | `string` | Optional | A message that is printed on the invoice when it is marked for remittance collection. It is intended to describe to the customer how they may make payment, and is configured by the merchant. |
| `Currency` | `string` | Optional | The ISO 4217 currency code (3 character string) representing the currency of invoice transaction. |
| `ConsolidationLevel` | [`InvoiceConsolidationLevel?`](../../doc/models/invoice-consolidation-level.md) | Optional | Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:<br><br>* "none": A normal invoice with no consolidation.<br>* "child": An invoice segment which has been combined into a consolidated invoice.<br>* "parent": A consolidated invoice, whose contents are composed of invoice segments.<br><br>"Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.<br><br>See also the [invoice consolidation documentation](https://maxio.zendesk.com/hc/en-us/articles/24252269909389-Invoice-Consolidation). |
| `ParentInvoiceUid` | `string` | Optional | For invoices with `consolidation_level` of `child`, this specifies the UID of the parent (consolidated) invoice. |
| `SubscriptionGroupId` | `int?` | Optional | - |
| `ParentInvoiceNumber` | `int?` | Optional | For invoices with `consolidation_level` of `child`, this specifies the number of the parent (consolidated) invoice. |
| `GroupPrimarySubscriptionId` | `int?` | Optional | For invoices with `consolidation_level` of `parent`, this specifies the ID of the subscription which was the primary subscription of the subscription group that generated the invoice. |
| `ProductName` | `string` | Optional | The name of the product subscribed when the invoice was generated. |
| `ProductFamilyName` | `string` | Optional | The name of the product family subscribed when the invoice was generated. |
| `Seller` | [`InvoiceSeller`](../../doc/models/invoice-seller.md) | Optional | Information about the seller (merchant) listed on the masthead of the invoice. |
| `Customer` | [`InvoiceCustomer`](../../doc/models/invoice-customer.md) | Optional | Information about the customer who is owner or recipient the invoiced subscription. |
| `Payer` | [`InvoicePayer`](../../doc/models/invoice-payer.md) | Optional | - |
| `RecipientEmails` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `5` |
| `NetTerms` | `int?` | Optional | - |
| `Memo` | `string` | Optional | The memo printed on invoices of any collection type.  This message is in control of the merchant. |
| `BillingAddress` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Optional | The invoice billing address. |
| `ShippingAddress` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Optional | The invoice shipping address. |
| `SubtotalAmount` | `string` | Optional | Subtotal of the invoice, which is the sum of all line items before discounts or taxes. |
| `DiscountAmount` | `string` | Optional | Total discount applied to the invoice. |
| `TaxAmount` | `string` | Optional | Total tax on the invoice. |
| `TotalAmount` | `string` | Optional | The invoice total, which is `subtotal_amount - discount_amount + tax_amount`.' |
| `CreditAmount` | `string` | Optional | The amount of credit (from credit notes) applied to this invoice.<br><br>Credits offset the amount due from the customer. |
| `DebitAmount` | `string` | Optional | - |
| `RefundAmount` | `string` | Optional | - |
| `PaidAmount` | `string` | Optional | The amount paid on the invoice by the customer. |
| `DueAmount` | `string` | Optional | Amount due on the invoice, which is `total_amount - credit_amount - paid_amount`. |
| `LineItems` | [`List<InvoiceLineItem>`](../../doc/models/invoice-line-item.md) | Optional | Line items on the invoice. |
| `Discounts` | [`List<InvoiceDiscount>`](../../doc/models/invoice-discount.md) | Optional | - |
| `Taxes` | [`List<InvoiceTax>`](../../doc/models/invoice-tax.md) | Optional | - |
| `Credits` | [`List<InvoiceCredit>`](../../doc/models/invoice-credit.md) | Optional | - |
| `Debits` | [`List<InvoiceDebit>`](../../doc/models/invoice-debit.md) | Optional | - |
| `Refunds` | [`List<InvoiceRefund>`](../../doc/models/invoice-refund.md) | Optional | - |
| `Payments` | [`List<InvoicePayment>`](../../doc/models/invoice-payment.md) | Optional | - |
| `CustomFields` | [`List<InvoiceCustomField>`](../../doc/models/invoice-custom-field.md) | Optional | - |
| `DisplaySettings` | [`InvoiceDisplaySettings`](../../doc/models/invoice-display-settings.md) | Optional | - |
| `AvataxDetails` | [`InvoiceAvataxDetails`](../../doc/models/invoice-avatax-details.md) | Optional | - |
| `PublicUrl` | `string` | Optional | The public URL of the invoice |
| `PreviousBalanceData` | [`InvoicePreviousBalance`](../../doc/models/invoice-previous-balance.md) | Optional | - |
| `PublicUrlExpiresOn` | `DateTime?` | Optional | The format is `"YYYY-MM-DD"`. |

## Example (as JSON)

```json
{
  "issue_date": "2024-01-01",
  "due_date": "2024-01-01",
  "paid_date": "2024-01-01",
  "public_url_expires_on": "2024-01-21",
  "id": 252,
  "uid": "uid0",
  "site_id": 178,
  "customer_id": 34,
  "subscription_id": 106
}
```

