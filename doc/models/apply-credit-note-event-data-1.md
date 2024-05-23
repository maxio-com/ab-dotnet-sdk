
# Apply Credit Note Event Data 1

Example schema for an `apply_credit_note` event

## Structure

`ApplyCreditNoteEventData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Required | Unique identifier for the credit note application. It is generated automatically by Chargify and has the prefix "cdt_" followed by alphanumeric characters. |
| `CreditNoteNumber` | `string` | Required | A unique, identifying string that appears on the credit note and in places it is referenced. |
| `CreditNoteUid` | `string` | Required | Unique identifier for the credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters. |
| `OriginalAmount` | `string` | Required | The full, original amount of the credit note. |
| `AppliedAmount` | `string` | Required | The amount of the credit note applied to invoice. |
| `TransactionTime` | `DateTimeOffset` | Required | The time the credit note was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |
| `Memo` | `string` | Required | The credit note memo. |
| `Role` | [`InvoiceRole2?`](../../doc/models/invoice-role-2.md) | Optional | The role of the credit note (e.g. 'general') |
| `ConsolidatedInvoice` | `bool?` | Optional | Shows whether it was applied to consolidated invoice or not |
| `AppliedCreditNotes` | [`List<AppliedCreditNoteData>`](../../doc/models/applied-credit-note-data.md) | Optional | List of credit notes applied to children invoices (if consolidated invoice) |
| `DebitNoteNumber` | `string` | Required | A unique, identifying string that appears on the debit note and in places it is referenced. |
| `DebitNoteUid` | `string` | Required | Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters. |
| `ConsolidationLevel` | [`InvoiceConsolidationLevel`](../../doc/models/invoice-consolidation-level.md) | Required | Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:<br><br>* "none": A normal invoice with no consolidation.<br>* "child": An invoice segment which has been combined into a consolidated invoice.<br>* "parent": A consolidated invoice, whose contents are composed of invoice segments.<br><br>"Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.<br><br>See also the [invoice consolidation documentation](https://chargify.zendesk.com/hc/en-us/articles/4407746391835). |
| `PaymentMethod` | [`ApplyCreditNoteEventData1PaymentMethod`](../../doc/models/containers/apply-credit-note-event-data-1-payment-method.md) | Required | This is a container for any-of cases. |
| `TransactionId` | `int` | Required | The Chargify id of the original payment |
| `ParentInvoiceNumber` | `int?` | Optional | For invoices with `consolidation_level` of `child`, this specifies the number of the parent (consolidated) invoice. |
| `RemainingPrepaymentAmount` | `string` | Optional | - |
| `Prepayment` | `bool` | Required | The flag that shows whether the original payment was a prepayment or not |
| `External` | `bool?` | Optional | - |
| `Id` | `long?` | Optional | - |
| `SiteId` | `int?` | Optional | ID of the site to which the invoice belongs. |
| `CustomerId` | `int?` | Optional | ID of the customer to which the invoice belongs. |
| `SubscriptionId` | `int?` | Optional | ID of the subscription that generated the invoice. |
| `Number` | `string` | Optional | A unique, identifying string that appears on the invoice and in places the invoice is referenced.<br><br>While the UID is long and not appropriate to show to customers, the number is usually shorter and consumable by the customer and the merchant alike. |
| `SequenceNumber` | `int?` | Optional | A monotonically increasing number assigned to invoices as they are created.  This number is unique within a site and can be used to sort and order invoices. |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `IssueDate` | `DateTime?` | Optional | Date the invoice was issued to the customer.  This is the date that the invoice was made available for payment.<br><br>The format is `"YYYY-MM-DD"`. |
| `DueDate` | `DateTime?` | Optional | Date the invoice is due.<br><br>The format is `"YYYY-MM-DD"`. |
| `PaidDate` | `DateTime?` | Optional | Date the invoice became fully paid.<br><br>If partial payments are applied to the invoice, this date will not be present until payment has been made in full.<br><br>The format is `"YYYY-MM-DD"`. |
| `Status` | [`InvoiceStatus?`](../../doc/models/invoice-status.md) | Optional | The current status of the invoice. See [Invoice Statuses](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405078794253-Introduction-to-Invoices#invoice-statuses) for more. |
| `ParentInvoiceId` | `int?` | Optional | - |
| `CollectionMethod` | [`CollectionMethod?`](../../doc/models/collection-method.md) | Optional | The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`. |
| `PaymentInstructions` | `string` | Optional | A message that is printed on the invoice when it is marked for remittance collection. It is intended to describe to the customer how they may make payment, and is configured by the merchant. |
| `Currency` | `string` | Optional | The ISO 4217 currency code (3 character string) representing the currency of invoice transaction. |
| `ParentInvoiceUid` | `string` | Optional | For invoices with `consolidation_level` of `child`, this specifies the UID of the parent (consolidated) invoice. |
| `SubscriptionGroupId` | `int?` | Optional | - |
| `GroupPrimarySubscriptionId` | `int?` | Optional | For invoices with `consolidation_level` of `parent`, this specifies the ID of the subscription which was the primary subscription of the subscription group that generated the invoice. |
| `ProductName` | `string` | Optional | The name of the product subscribed when the invoice was generated. |
| `ProductFamilyName` | `string` | Optional | The name of the product family subscribed when the invoice was generated. |
| `Seller` | [`InvoiceSeller`](../../doc/models/invoice-seller.md) | Optional | Information about the seller (merchant) listed on the masthead of the invoice. |
| `Customer` | [`InvoiceCustomer`](../../doc/models/invoice-customer.md) | Optional | Information about the customer who is owner or recipient the invoiced subscription. |
| `Payer` | [`InvoicePayer`](../../doc/models/invoice-payer.md) | Optional | - |
| `RecipientEmails` | `List<string>` | Optional | **Constraints**: *Maximum Items*: `5` |
| `NetTerms` | `int?` | Optional | - |
| `BillingAddress` | [`BillingAddress`](../../doc/models/billing-address.md) | Optional | - |
| `ShippingAddress` | [`ShippingAddress`](../../doc/models/shipping-address.md) | Optional | - |
| `SubtotalAmount` | `string` | Optional | Subtotal of the invoice, which is the sum of all line items before discounts or taxes. |
| `DiscountAmount` | `string` | Optional | Total discount applied to the invoice. |
| `TaxAmount` | `string` | Optional | Total tax on the invoice. |
| `TotalAmount` | `string` | Required | The invoice total, which is `subtotal_amount - discount_amount + tax_amount`.' |
| `CreditAmount` | `string` | Optional | The amount of credit (from credit notes) applied to this invoice.<br><br>Credits offset the amount due from the customer. |
| `RefundAmount` | `string` | Required | The amount of the refund. |
| `PaidAmount` | `string` | Optional | The amount paid on the invoice by the customer. |
| `DueAmount` | `string` | Required | Amount due on the invoice, which is `total_amount - credit_amount - paid_amount`. |
| `LineItems` | [`List<InvoiceLineItem2>`](../../doc/models/invoice-line-item-2.md) | Optional | Line items on the invoice. |
| `Discounts` | [`List<InvoiceDiscount>`](../../doc/models/invoice-discount.md) | Optional | - |
| `Taxes` | [`List<InvoiceTax>`](../../doc/models/invoice-tax.md) | Optional | - |
| `Credits` | [`List<InvoiceCredit>`](../../doc/models/invoice-credit.md) | Optional | - |
| `Refunds` | [`List<InvoiceRefund>`](../../doc/models/invoice-refund.md) | Optional | - |
| `Payments` | [`List<InvoicePayment>`](../../doc/models/invoice-payment.md) | Optional | - |
| `CustomFields` | [`List<InvoiceCustomField>`](../../doc/models/invoice-custom-field.md) | Optional | - |
| `DisplaySettings` | [`InvoiceDisplaySettings`](../../doc/models/invoice-display-settings.md) | Optional | - |
| `PublicUrl` | `string` | Optional | The public URL of the invoice |
| `PreviousBalanceData` | [`InvoicePreviousBalance`](../../doc/models/invoice-previous-balance.md) | Optional | - |
| `ChargebackStatus` | [`ChargebackStatus`](../../doc/models/chargeback-status.md) | Required | - |
| `FromCollectionMethod` | `string` | Required | The previous collection method of the invoice. |
| `ToCollectionMethod` | `string` | Required | The new collection method of the invoice. |
| `GatewayTransId` | `string` | Optional | Identifier for the transaction within the payment gateway. |
| `Amount` | `string` | Optional | The monetary value associated with the linked payment, expressed in dollars. |
| `FromStatus` | `object` | Required | - |
| `ToStatus` | `object` | Required | - |
| `AppliedDate` | `DateTime?` | Optional | Credit notes are applied to invoices to offset invoiced amounts - they reduce the amount due. This field is the date the credit note became fully applied to invoices.<br><br>If the credit note has been partially applied, this field will not have a value until it has been fully applied.<br><br>The format is `"YYYY-MM-DD"`. |
| `RemainingAmount` | `string` | Optional | The amount of the credit note remaining to be applied to invoices, which is `total_amount - applied_amount`. |
| `Applications` | [`List<CreditNoteApplication>`](../../doc/models/credit-note-application.md) | Optional | - |
| `OriginInvoices` | [`List<OriginInvoice>`](../../doc/models/origin-invoice.md) | Optional | An array of origin invoices for the credit note. Learn more about [Origin Invoice from our docs](https://chargify.zendesk.com/hc/en-us/articles/4407753036699#origin-invoices) |
| `OriginCreditNoteUid` | `string` | Optional | Unique identifier for the connected credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters.<br><br>While the UID is long and not appropriate to show to customers, the number is usually shorter and consumable by the customer and the merchant alike. |
| `OriginCreditNoteNumber` | `string` | Optional | A unique, identifying string of the connected credit note. |
| `AmountInCents` | `int` | Required | The monetary value of the payment, expressed in cents. |
| `ApplyCredit` | `bool` | Required | If true, credit was created and applied it to the invoice. |
| `CreditNoteAttributes` | [`CreditNote1`](../../doc/models/credit-note-1.md) | Required | - |
| `PaymentId` | `int` | Required | The ID of the payment transaction to be refunded. |
| `RefundId` | `int` | Required | The ID of the refund transaction. |
| `IsAdvanceInvoice` | `bool` | Required | If true, the invoice is an advance invoice. |
| `Reason` | `string` | Required | The reason for the void. |

## Example (as JSON)

```json
{
  "uid": "uid6",
  "credit_note_number": "credit_note_number0",
  "credit_note_uid": "credit_note_uid0",
  "original_amount": "original_amount0",
  "applied_amount": "applied_amount2",
  "transaction_time": "2016-03-13T12:52:32.123Z",
  "memo": "memo0",
  "debit_note_number": "debit_note_number6",
  "debit_note_uid": "debit_note_uid2",
  "consolidation_level": "child",
  "payment_method": {
    "type": "apple_pay"
  },
  "transaction_id": 138,
  "prepayment": false,
  "issue_date": "2024-01-01",
  "due_date": "2024-01-01",
  "paid_date": "2024-01-01",
  "total_amount": "total_amount2",
  "refund_amount": "refund_amount2",
  "due_amount": "due_amount8",
  "chargeback_status": "won",
  "from_collection_method": "from_collection_method4",
  "to_collection_method": "to_collection_method8",
  "from_status": {
    "key1": "val1",
    "key2": "val2"
  },
  "to_status": {
    "key1": "val1",
    "key2": "val2"
  },
  "amount_in_cents": 96,
  "apply_credit": false,
  "credit_note_attributes": {
    "uid": "uid2",
    "site_id": 72,
    "customer_id": 184,
    "subscription_id": 0,
    "number": "number0"
  },
  "payment_id": 8,
  "refund_id": 52,
  "is_advance_invoice": false,
  "reason": "reason2",
  "role": "unset",
  "consolidated_invoice": false,
  "applied_credit_notes": [
    {
      "uid": "uid4",
      "number": "number8"
    },
    {
      "uid": "uid4",
      "number": "number8"
    }
  ],
  "parent_invoice_number": 232,
  "remaining_prepayment_amount": "remaining_prepayment_amount6"
}
```

