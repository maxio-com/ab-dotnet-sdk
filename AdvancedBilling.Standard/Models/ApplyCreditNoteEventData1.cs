// <copyright file="ApplyCreditNoteEventData1.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ApplyCreditNoteEventData1.
    /// </summary>
    public class ApplyCreditNoteEventData1 : BaseModel
    {
        private int? parentInvoiceNumber;
        private string remainingPrepaymentAmount;
        private DateTime? paidDate;
        private int? parentInvoiceId;
        private string parentInvoiceUid;
        private int? subscriptionGroupId;
        private int? groupPrimarySubscriptionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "parent_invoice_number", false },
            { "remaining_prepayment_amount", false },
            { "paid_date", false },
            { "parent_invoice_id", false },
            { "parent_invoice_uid", false },
            { "subscription_group_id", false },
            { "group_primary_subscription_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyCreditNoteEventData1"/> class.
        /// </summary>
        public ApplyCreditNoteEventData1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyCreditNoteEventData1"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="creditNoteNumber">credit_note_number.</param>
        /// <param name="creditNoteUid">credit_note_uid.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="debitNoteNumber">debit_note_number.</param>
        /// <param name="debitNoteUid">debit_note_uid.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="paymentMethod">payment_method.</param>
        /// <param name="transactionId">transaction_id.</param>
        /// <param name="prepayment">prepayment.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="refundAmount">refund_amount.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="chargebackStatus">chargeback_status.</param>
        /// <param name="fromCollectionMethod">from_collection_method.</param>
        /// <param name="toCollectionMethod">to_collection_method.</param>
        /// <param name="fromStatus">from_status.</param>
        /// <param name="toStatus">to_status.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="applyCredit">apply_credit.</param>
        /// <param name="creditNoteAttributes">credit_note_attributes.</param>
        /// <param name="paymentId">payment_id.</param>
        /// <param name="refundId">refund_id.</param>
        /// <param name="isAdvanceInvoice">is_advance_invoice.</param>
        /// <param name="reason">reason.</param>
        /// <param name="memo">memo.</param>
        /// <param name="role">role.</param>
        /// <param name="consolidatedInvoice">consolidated_invoice.</param>
        /// <param name="appliedCreditNotes">applied_credit_notes.</param>
        /// <param name="parentInvoiceNumber">parent_invoice_number.</param>
        /// <param name="remainingPrepaymentAmount">remaining_prepayment_amount.</param>
        /// <param name="external">external.</param>
        /// <param name="id">id.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="number">number.</param>
        /// <param name="sequenceNumber">sequence_number.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="issueDate">issue_date.</param>
        /// <param name="dueDate">due_date.</param>
        /// <param name="paidDate">paid_date.</param>
        /// <param name="status">status.</param>
        /// <param name="parentInvoiceId">parent_invoice_id.</param>
        /// <param name="collectionMethod">collection_method.</param>
        /// <param name="paymentInstructions">payment_instructions.</param>
        /// <param name="currency">currency.</param>
        /// <param name="parentInvoiceUid">parent_invoice_uid.</param>
        /// <param name="subscriptionGroupId">subscription_group_id.</param>
        /// <param name="groupPrimarySubscriptionId">group_primary_subscription_id.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="productFamilyName">product_family_name.</param>
        /// <param name="seller">seller.</param>
        /// <param name="customer">customer.</param>
        /// <param name="payer">payer.</param>
        /// <param name="recipientEmails">recipient_emails.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="subtotalAmount">subtotal_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="creditAmount">credit_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="credits">credits.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="payments">payments.</param>
        /// <param name="customFields">custom_fields.</param>
        /// <param name="displaySettings">display_settings.</param>
        /// <param name="publicUrl">public_url.</param>
        /// <param name="previousBalanceData">previous_balance_data.</param>
        /// <param name="gatewayTransId">gateway_trans_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="appliedDate">applied_date.</param>
        /// <param name="remainingAmount">remaining_amount.</param>
        /// <param name="applications">applications.</param>
        /// <param name="originInvoices">origin_invoices.</param>
        /// <param name="originCreditNoteUid">origin_credit_note_uid.</param>
        /// <param name="originCreditNoteNumber">origin_credit_note_number.</param>
        public ApplyCreditNoteEventData1(
            string uid,
            string creditNoteNumber,
            string creditNoteUid,
            string originalAmount,
            string appliedAmount,
            DateTimeOffset transactionTime,
            string debitNoteNumber,
            string debitNoteUid,
            Models.InvoiceConsolidationLevel consolidationLevel,
            ApplyCreditNoteEventData1PaymentMethod paymentMethod,
            int transactionId,
            bool prepayment,
            string totalAmount,
            string refundAmount,
            string dueAmount,
            Models.ChargebackStatus chargebackStatus,
            string fromCollectionMethod,
            string toCollectionMethod,
            object fromStatus,
            object toStatus,
            int amountInCents,
            bool applyCredit,
            Models.CreditNote1 creditNoteAttributes,
            int paymentId,
            int refundId,
            bool isAdvanceInvoice,
            string reason,
            string memo = null,
            Models.InvoiceRole2? role = null,
            bool? consolidatedInvoice = null,
            List<Models.AppliedCreditNoteData> appliedCreditNotes = null,
            int? parentInvoiceNumber = null,
            string remainingPrepaymentAmount = null,
            bool? external = null,
            long? id = null,
            int? siteId = null,
            int? customerId = null,
            int? subscriptionId = null,
            string number = null,
            int? sequenceNumber = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            DateTime? issueDate = null,
            DateTime? dueDate = null,
            DateTime? paidDate = null,
            Models.InvoiceStatus? status = null,
            int? parentInvoiceId = null,
            Models.CollectionMethod? collectionMethod = null,
            string paymentInstructions = null,
            string currency = null,
            string parentInvoiceUid = null,
            int? subscriptionGroupId = null,
            int? groupPrimarySubscriptionId = null,
            string productName = null,
            string productFamilyName = null,
            Models.InvoiceSeller seller = null,
            Models.InvoiceCustomer customer = null,
            Models.InvoicePayer payer = null,
            List<string> recipientEmails = null,
            int? netTerms = null,
            Models.BillingAddress billingAddress = null,
            Models.ShippingAddress shippingAddress = null,
            string subtotalAmount = null,
            string discountAmount = null,
            string taxAmount = null,
            string creditAmount = null,
            string paidAmount = null,
            List<Models.InvoiceLineItem2> lineItems = null,
            List<Models.InvoiceDiscount> discounts = null,
            List<Models.InvoiceTax> taxes = null,
            List<Models.InvoiceCredit> credits = null,
            List<Models.InvoiceRefund> refunds = null,
            List<Models.InvoicePayment> payments = null,
            List<Models.InvoiceCustomField> customFields = null,
            Models.InvoiceDisplaySettings displaySettings = null,
            string publicUrl = null,
            Models.InvoicePreviousBalance previousBalanceData = null,
            string gatewayTransId = null,
            string amount = null,
            DateTime? appliedDate = null,
            string remainingAmount = null,
            List<Models.CreditNoteApplication> applications = null,
            List<Models.OriginInvoice> originInvoices = null,
            string originCreditNoteUid = null,
            string originCreditNoteNumber = null)
        {
            this.Uid = uid;
            this.CreditNoteNumber = creditNoteNumber;
            this.CreditNoteUid = creditNoteUid;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
            this.TransactionTime = transactionTime;
            this.Memo = memo;
            this.Role = role;
            this.ConsolidatedInvoice = consolidatedInvoice;
            this.AppliedCreditNotes = appliedCreditNotes;
            this.DebitNoteNumber = debitNoteNumber;
            this.DebitNoteUid = debitNoteUid;
            this.ConsolidationLevel = consolidationLevel;
            this.PaymentMethod = paymentMethod;
            this.TransactionId = transactionId;
            if (parentInvoiceNumber != null)
            {
                this.ParentInvoiceNumber = parentInvoiceNumber;
            }

            if (remainingPrepaymentAmount != null)
            {
                this.RemainingPrepaymentAmount = remainingPrepaymentAmount;
            }

            this.Prepayment = prepayment;
            this.External = external;
            this.Id = id;
            this.SiteId = siteId;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.Number = number;
            this.SequenceNumber = sequenceNumber;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IssueDate = issueDate;
            this.DueDate = dueDate;
            if (paidDate != null)
            {
                this.PaidDate = paidDate;
            }

            this.Status = status;
            if (parentInvoiceId != null)
            {
                this.ParentInvoiceId = parentInvoiceId;
            }

            this.CollectionMethod = collectionMethod;
            this.PaymentInstructions = paymentInstructions;
            this.Currency = currency;
            if (parentInvoiceUid != null)
            {
                this.ParentInvoiceUid = parentInvoiceUid;
            }

            if (subscriptionGroupId != null)
            {
                this.SubscriptionGroupId = subscriptionGroupId;
            }

            if (groupPrimarySubscriptionId != null)
            {
                this.GroupPrimarySubscriptionId = groupPrimarySubscriptionId;
            }

            this.ProductName = productName;
            this.ProductFamilyName = productFamilyName;
            this.Seller = seller;
            this.Customer = customer;
            this.Payer = payer;
            this.RecipientEmails = recipientEmails;
            this.NetTerms = netTerms;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.SubtotalAmount = subtotalAmount;
            this.DiscountAmount = discountAmount;
            this.TaxAmount = taxAmount;
            this.TotalAmount = totalAmount;
            this.CreditAmount = creditAmount;
            this.RefundAmount = refundAmount;
            this.PaidAmount = paidAmount;
            this.DueAmount = dueAmount;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Credits = credits;
            this.Refunds = refunds;
            this.Payments = payments;
            this.CustomFields = customFields;
            this.DisplaySettings = displaySettings;
            this.PublicUrl = publicUrl;
            this.PreviousBalanceData = previousBalanceData;
            this.ChargebackStatus = chargebackStatus;
            this.FromCollectionMethod = fromCollectionMethod;
            this.ToCollectionMethod = toCollectionMethod;
            this.GatewayTransId = gatewayTransId;
            this.Amount = amount;
            this.FromStatus = fromStatus;
            this.ToStatus = toStatus;
            this.AppliedDate = appliedDate;
            this.RemainingAmount = remainingAmount;
            this.Applications = applications;
            this.OriginInvoices = originInvoices;
            this.OriginCreditNoteUid = originCreditNoteUid;
            this.OriginCreditNoteNumber = originCreditNoteNumber;
            this.AmountInCents = amountInCents;
            this.ApplyCredit = applyCredit;
            this.CreditNoteAttributes = creditNoteAttributes;
            this.PaymentId = paymentId;
            this.RefundId = refundId;
            this.IsAdvanceInvoice = isAdvanceInvoice;
            this.Reason = reason;
        }

        /// <summary>
        /// Unique identifier for the credit note application. It is generated automatically by Chargify and has the prefix "cdt_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on the credit note and in places it is referenced.
        /// </summary>
        [JsonProperty("credit_note_number")]
        public string CreditNoteNumber { get; set; }

        /// <summary>
        /// Unique identifier for the credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("credit_note_uid")]
        public string CreditNoteUid { get; set; }

        /// <summary>
        /// The full, original amount of the credit note.
        /// </summary>
        [JsonProperty("original_amount")]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the credit note applied to invoice.
        /// </summary>
        [JsonProperty("applied_amount")]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The time the credit note was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z"
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time")]
        public DateTimeOffset TransactionTime { get; set; }

        /// <summary>
        /// The credit note memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Include)]
        public string Memo { get; set; }

        /// <summary>
        /// The role of the credit note (e.g. 'general')
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceRole2? Role { get; set; }

        /// <summary>
        /// Shows whether it was applied to consolidated invoice or not
        /// </summary>
        [JsonProperty("consolidated_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsolidatedInvoice { get; set; }

        /// <summary>
        /// List of credit notes applied to children invoices (if consolidated invoice)
        /// </summary>
        [JsonProperty("applied_credit_notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AppliedCreditNoteData> AppliedCreditNotes { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on the debit note and in places it is referenced.
        /// </summary>
        [JsonProperty("debit_note_number")]
        public string DebitNoteNumber { get; set; }

        /// <summary>
        /// Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("debit_note_uid")]
        public string DebitNoteUid { get; set; }

        /// <summary>
        /// Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:
        /// * "none": A normal invoice with no consolidation.
        /// * "child": An invoice segment which has been combined into a consolidated invoice.
        /// * "parent": A consolidated invoice, whose contents are composed of invoice segments.
        /// "Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.
        /// See also the [invoice consolidation documentation](https://chargify.zendesk.com/hc/en-us/articles/4407746391835).
        /// </summary>
        [JsonProperty("consolidation_level")]
        public Models.InvoiceConsolidationLevel ConsolidationLevel { get; set; }

        /// <summary>
        /// A nested data structure detailing the method of payment
        /// </summary>
        [JsonProperty("payment_method")]
        public ApplyCreditNoteEventData1PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// The Chargify id of the original payment
        /// </summary>
        [JsonProperty("transaction_id")]
        public int TransactionId { get; set; }

        /// <summary>
        /// For invoices with `consolidation_level` of `child`, this specifies the number of the parent (consolidated) invoice.
        /// </summary>
        [JsonProperty("parent_invoice_number")]
        public int? ParentInvoiceNumber
        {
            get
            {
                return this.parentInvoiceNumber;
            }

            set
            {
                this.shouldSerialize["parent_invoice_number"] = true;
                this.parentInvoiceNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets RemainingPrepaymentAmount.
        /// </summary>
        [JsonProperty("remaining_prepayment_amount")]
        public string RemainingPrepaymentAmount
        {
            get
            {
                return this.remainingPrepaymentAmount;
            }

            set
            {
                this.shouldSerialize["remaining_prepayment_amount"] = true;
                this.remainingPrepaymentAmount = value;
            }
        }

        /// <summary>
        /// The flag that shows whether the original payment was a prepayment or not
        /// </summary>
        [JsonProperty("prepayment")]
        public bool Prepayment { get; set; }

        /// <summary>
        /// Gets or sets External.
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// ID of the site to which the invoice belongs.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// ID of the customer to which the invoice belongs.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// ID of the subscription that generated the invoice.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on the invoice and in places the invoice is referenced.
        /// While the UID is long and not appropriate to show to customers, the number is usually shorter and consumable by the customer and the merchant alike.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// A monotonically increasing number assigned to invoices as they are created.  This number is unique within a site and can be used to sort and order invoices.
        /// </summary>
        [JsonProperty("sequence_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Date the invoice was issued to the customer.  This is the date that the invoice was made available for payment.
        /// The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Date the invoice is due.
        /// The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Date the invoice became fully paid.
        /// If partial payments are applied to the invoice, this date will not be present until payment has been made in full.
        /// The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("paid_date")]
        public DateTime? PaidDate
        {
            get
            {
                return this.paidDate;
            }

            set
            {
                this.shouldSerialize["paid_date"] = true;
                this.paidDate = value;
            }
        }

        /// <summary>
        /// The current status of the invoice. See [Invoice Statuses](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405078794253-Introduction-to-Invoices#invoice-statuses) for more.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets ParentInvoiceId.
        /// </summary>
        [JsonProperty("parent_invoice_id")]
        public int? ParentInvoiceId
        {
            get
            {
                return this.parentInvoiceId;
            }

            set
            {
                this.shouldSerialize["parent_invoice_id"] = true;
                this.parentInvoiceId = value;
            }
        }

        /// <summary>
        /// The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`.
        /// </summary>
        [JsonProperty("collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CollectionMethod? CollectionMethod { get; set; }

        /// <summary>
        /// A message that is printed on the invoice when it is marked for remittance collection. It is intended to describe to the customer how they may make payment, and is configured by the merchant.
        /// </summary>
        [JsonProperty("payment_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentInstructions { get; set; }

        /// <summary>
        /// The ISO 4217 currency code (3 character string) representing the currency of invoice transaction.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// For invoices with `consolidation_level` of `child`, this specifies the UID of the parent (consolidated) invoice.
        /// </summary>
        [JsonProperty("parent_invoice_uid")]
        public string ParentInvoiceUid
        {
            get
            {
                return this.parentInvoiceUid;
            }

            set
            {
                this.shouldSerialize["parent_invoice_uid"] = true;
                this.parentInvoiceUid = value;
            }
        }

        /// <summary>
        /// Gets or sets SubscriptionGroupId.
        /// </summary>
        [JsonProperty("subscription_group_id")]
        public int? SubscriptionGroupId
        {
            get
            {
                return this.subscriptionGroupId;
            }

            set
            {
                this.shouldSerialize["subscription_group_id"] = true;
                this.subscriptionGroupId = value;
            }
        }

        /// <summary>
        /// For invoices with `consolidation_level` of `parent`, this specifies the ID of the subscription which was the primary subscription of the subscription group that generated the invoice.
        /// </summary>
        [JsonProperty("group_primary_subscription_id")]
        public int? GroupPrimarySubscriptionId
        {
            get
            {
                return this.groupPrimarySubscriptionId;
            }

            set
            {
                this.shouldSerialize["group_primary_subscription_id"] = true;
                this.groupPrimarySubscriptionId = value;
            }
        }

        /// <summary>
        /// The name of the product subscribed when the invoice was generated.
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// The name of the product family subscribed when the invoice was generated.
        /// </summary>
        [JsonProperty("product_family_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductFamilyName { get; set; }

        /// <summary>
        /// Information about the seller (merchant) listed on the masthead of the invoice.
        /// </summary>
        [JsonProperty("seller", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceSeller Seller { get; set; }

        /// <summary>
        /// Information about the customer who is owner or recipient the invoiced subscription.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceCustomer Customer { get; set; }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoicePayer Payer { get; set; }

        /// <summary>
        /// Gets or sets RecipientEmails.
        /// </summary>
        [JsonProperty("recipient_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RecipientEmails { get; set; }

        /// <summary>
        /// Gets or sets NetTerms.
        /// </summary>
        [JsonProperty("net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetTerms { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets ShippingAddress.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Subtotal of the invoice, which is the sum of all line items before discounts or taxes.
        /// </summary>
        [JsonProperty("subtotal_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalAmount { get; set; }

        /// <summary>
        /// Total discount applied to the invoice.
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Total tax on the invoice.
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// The invoice total, which is `subtotal_amount - discount_amount + tax_amount`.'
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// The amount of credit (from credit notes) applied to this invoice.
        /// Credits offset the amount due from the customer.
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// The amount of the refund.
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// The amount paid on the invoice by the customer.
        /// </summary>
        [JsonProperty("paid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidAmount { get; set; }

        /// <summary>
        /// Amount due on the invoice, which is `total_amount - credit_amount - paid_amount`.
        /// </summary>
        [JsonProperty("due_amount")]
        public string DueAmount { get; set; }

        /// <summary>
        /// Line items on the invoice.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceLineItem2> LineItems { get; set; }

        /// <summary>
        /// Gets or sets Discounts.
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceDiscount> Discounts { get; set; }

        /// <summary>
        /// Gets or sets Taxes.
        /// </summary>
        [JsonProperty("taxes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceTax> Taxes { get; set; }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceCredit> Credits { get; set; }

        /// <summary>
        /// Gets or sets Refunds.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceRefund> Refunds { get; set; }

        /// <summary>
        /// Gets or sets Payments.
        /// </summary>
        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoicePayment> Payments { get; set; }

        /// <summary>
        /// Gets or sets CustomFields.
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets DisplaySettings.
        /// </summary>
        [JsonProperty("display_settings", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceDisplaySettings DisplaySettings { get; set; }

        /// <summary>
        /// The public URL of the invoice
        /// </summary>
        [JsonProperty("public_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicUrl { get; set; }

        /// <summary>
        /// Gets or sets PreviousBalanceData.
        /// </summary>
        [JsonProperty("previous_balance_data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoicePreviousBalance PreviousBalanceData { get; set; }

        /// <summary>
        /// Gets or sets ChargebackStatus.
        /// </summary>
        [JsonProperty("chargeback_status")]
        public Models.ChargebackStatus ChargebackStatus { get; set; }

        /// <summary>
        /// The previous collection method of the invoice.
        /// </summary>
        [JsonProperty("from_collection_method")]
        public string FromCollectionMethod { get; set; }

        /// <summary>
        /// The new collection method of the invoice.
        /// </summary>
        [JsonProperty("to_collection_method")]
        public string ToCollectionMethod { get; set; }

        /// <summary>
        /// Identifier for the transaction within the payment gateway.
        /// </summary>
        [JsonProperty("gateway_trans_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayTransId { get; set; }

        /// <summary>
        /// The monetary value associated with the linked payment, expressed in dollars.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets FromStatus.
        /// </summary>
        [JsonProperty("from_status")]
        public object FromStatus { get; set; }

        /// <summary>
        /// Gets or sets ToStatus.
        /// </summary>
        [JsonProperty("to_status")]
        public object ToStatus { get; set; }

        /// <summary>
        /// Credit notes are applied to invoices to offset invoiced amounts - they reduce the amount due. This field is the date the credit note became fully applied to invoices.
        /// If the credit note has been partially applied, this field will not have a value until it has been fully applied.
        /// The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("applied_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AppliedDate { get; set; }

        /// <summary>
        /// The amount of the credit note remaining to be applied to invoices, which is `total_amount - applied_amount`.
        /// </summary>
        [JsonProperty("remaining_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingAmount { get; set; }

        /// <summary>
        /// Gets or sets Applications.
        /// </summary>
        [JsonProperty("applications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreditNoteApplication> Applications { get; set; }

        /// <summary>
        /// An array of origin invoices for the credit note. Learn more about [Origin Invoice from our docs](https://chargify.zendesk.com/hc/en-us/articles/4407753036699#origin-invoices)
        /// </summary>
        [JsonProperty("origin_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OriginInvoice> OriginInvoices { get; set; }

        /// <summary>
        /// Unique identifier for the connected credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters.
        /// While the UID is long and not appropriate to show to customers, the number is usually shorter and consumable by the customer and the merchant alike.
        /// </summary>
        [JsonProperty("origin_credit_note_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginCreditNoteUid { get; set; }

        /// <summary>
        /// A unique, identifying string of the connected credit note.
        /// </summary>
        [JsonProperty("origin_credit_note_number", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginCreditNoteNumber { get; set; }

        /// <summary>
        /// The monetary value of the payment, expressed in cents.
        /// </summary>
        [JsonProperty("amount_in_cents")]
        public int AmountInCents { get; set; }

        /// <summary>
        /// If true, credit was created and applied it to the invoice.
        /// </summary>
        [JsonProperty("apply_credit")]
        public bool ApplyCredit { get; set; }

        /// <summary>
        /// Gets or sets CreditNoteAttributes.
        /// </summary>
        [JsonProperty("credit_note_attributes")]
        public Models.CreditNote1 CreditNoteAttributes { get; set; }

        /// <summary>
        /// The ID of the payment transaction to be refunded.
        /// </summary>
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        /// <summary>
        /// The ID of the refund transaction.
        /// </summary>
        [JsonProperty("refund_id")]
        public int RefundId { get; set; }

        /// <summary>
        /// If true, the invoice is an advance invoice.
        /// </summary>
        [JsonProperty("is_advance_invoice")]
        public bool IsAdvanceInvoice { get; set; }

        /// <summary>
        /// The reason for the void.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplyCreditNoteEventData1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentInvoiceNumber()
        {
            this.shouldSerialize["parent_invoice_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRemainingPrepaymentAmount()
        {
            this.shouldSerialize["remaining_prepayment_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaidDate()
        {
            this.shouldSerialize["paid_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentInvoiceId()
        {
            this.shouldSerialize["parent_invoice_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentInvoiceUid()
        {
            this.shouldSerialize["parent_invoice_uid"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubscriptionGroupId()
        {
            this.shouldSerialize["subscription_group_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGroupPrimarySubscriptionId()
        {
            this.shouldSerialize["group_primary_subscription_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentInvoiceNumber()
        {
            return this.shouldSerialize["parent_invoice_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRemainingPrepaymentAmount()
        {
            return this.shouldSerialize["remaining_prepayment_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidDate()
        {
            return this.shouldSerialize["paid_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentInvoiceId()
        {
            return this.shouldSerialize["parent_invoice_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentInvoiceUid()
        {
            return this.shouldSerialize["parent_invoice_uid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionGroupId()
        {
            return this.shouldSerialize["subscription_group_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGroupPrimarySubscriptionId()
        {
            return this.shouldSerialize["group_primary_subscription_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ApplyCreditNoteEventData1 other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.CreditNoteNumber == null && other.CreditNoteNumber == null) || (this.CreditNoteNumber?.Equals(other.CreditNoteNumber) == true)) &&
                ((this.CreditNoteUid == null && other.CreditNoteUid == null) || (this.CreditNoteUid?.Equals(other.CreditNoteUid) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                this.TransactionTime.Equals(other.TransactionTime) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.ConsolidatedInvoice == null && other.ConsolidatedInvoice == null) || (this.ConsolidatedInvoice?.Equals(other.ConsolidatedInvoice) == true)) &&
                ((this.AppliedCreditNotes == null && other.AppliedCreditNotes == null) || (this.AppliedCreditNotes?.Equals(other.AppliedCreditNotes) == true)) &&
                ((this.DebitNoteNumber == null && other.DebitNoteNumber == null) || (this.DebitNoteNumber?.Equals(other.DebitNoteNumber) == true)) &&
                ((this.DebitNoteUid == null && other.DebitNoteUid == null) || (this.DebitNoteUid?.Equals(other.DebitNoteUid) == true)) &&
                this.ConsolidationLevel.Equals(other.ConsolidationLevel) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                this.TransactionId.Equals(other.TransactionId) &&
                ((this.ParentInvoiceNumber == null && other.ParentInvoiceNumber == null) || (this.ParentInvoiceNumber?.Equals(other.ParentInvoiceNumber) == true)) &&
                ((this.RemainingPrepaymentAmount == null && other.RemainingPrepaymentAmount == null) || (this.RemainingPrepaymentAmount?.Equals(other.RemainingPrepaymentAmount) == true)) &&
                this.Prepayment.Equals(other.Prepayment) &&
                ((this.External == null && other.External == null) || (this.External?.Equals(other.External) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SiteId == null && other.SiteId == null) || (this.SiteId?.Equals(other.SiteId) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.SequenceNumber == null && other.SequenceNumber == null) || (this.SequenceNumber?.Equals(other.SequenceNumber) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.DueDate == null && other.DueDate == null) || (this.DueDate?.Equals(other.DueDate) == true)) &&
                ((this.PaidDate == null && other.PaidDate == null) || (this.PaidDate?.Equals(other.PaidDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.ParentInvoiceId == null && other.ParentInvoiceId == null) || (this.ParentInvoiceId?.Equals(other.ParentInvoiceId) == true)) &&
                ((this.CollectionMethod == null && other.CollectionMethod == null) || (this.CollectionMethod?.Equals(other.CollectionMethod) == true)) &&
                ((this.PaymentInstructions == null && other.PaymentInstructions == null) || (this.PaymentInstructions?.Equals(other.PaymentInstructions) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.ParentInvoiceUid == null && other.ParentInvoiceUid == null) || (this.ParentInvoiceUid?.Equals(other.ParentInvoiceUid) == true)) &&
                ((this.SubscriptionGroupId == null && other.SubscriptionGroupId == null) || (this.SubscriptionGroupId?.Equals(other.SubscriptionGroupId) == true)) &&
                ((this.GroupPrimarySubscriptionId == null && other.GroupPrimarySubscriptionId == null) || (this.GroupPrimarySubscriptionId?.Equals(other.GroupPrimarySubscriptionId) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductFamilyName == null && other.ProductFamilyName == null) || (this.ProductFamilyName?.Equals(other.ProductFamilyName) == true)) &&
                ((this.Seller == null && other.Seller == null) || (this.Seller?.Equals(other.Seller) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                ((this.RecipientEmails == null && other.RecipientEmails == null) || (this.RecipientEmails?.Equals(other.RecipientEmails) == true)) &&
                ((this.NetTerms == null && other.NetTerms == null) || (this.NetTerms?.Equals(other.NetTerms) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.ShippingAddress == null && other.ShippingAddress == null) || (this.ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((this.SubtotalAmount == null && other.SubtotalAmount == null) || (this.SubtotalAmount?.Equals(other.SubtotalAmount) == true)) &&
                ((this.DiscountAmount == null && other.DiscountAmount == null) || (this.DiscountAmount?.Equals(other.DiscountAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.CreditAmount == null && other.CreditAmount == null) || (this.CreditAmount?.Equals(other.CreditAmount) == true)) &&
                ((this.RefundAmount == null && other.RefundAmount == null) || (this.RefundAmount?.Equals(other.RefundAmount) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                ((this.DueAmount == null && other.DueAmount == null) || (this.DueAmount?.Equals(other.DueAmount) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Taxes == null && other.Taxes == null) || (this.Taxes?.Equals(other.Taxes) == true)) &&
                ((this.Credits == null && other.Credits == null) || (this.Credits?.Equals(other.Credits) == true)) &&
                ((this.Refunds == null && other.Refunds == null) || (this.Refunds?.Equals(other.Refunds) == true)) &&
                ((this.Payments == null && other.Payments == null) || (this.Payments?.Equals(other.Payments) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.DisplaySettings == null && other.DisplaySettings == null) || (this.DisplaySettings?.Equals(other.DisplaySettings) == true)) &&
                ((this.PublicUrl == null && other.PublicUrl == null) || (this.PublicUrl?.Equals(other.PublicUrl) == true)) &&
                ((this.PreviousBalanceData == null && other.PreviousBalanceData == null) || (this.PreviousBalanceData?.Equals(other.PreviousBalanceData) == true)) &&
                this.ChargebackStatus.Equals(other.ChargebackStatus) &&
                ((this.FromCollectionMethod == null && other.FromCollectionMethod == null) || (this.FromCollectionMethod?.Equals(other.FromCollectionMethod) == true)) &&
                ((this.ToCollectionMethod == null && other.ToCollectionMethod == null) || (this.ToCollectionMethod?.Equals(other.ToCollectionMethod) == true)) &&
                ((this.GatewayTransId == null && other.GatewayTransId == null) || (this.GatewayTransId?.Equals(other.GatewayTransId) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.FromStatus == null && other.FromStatus == null) || (this.FromStatus?.Equals(other.FromStatus) == true)) &&
                ((this.ToStatus == null && other.ToStatus == null) || (this.ToStatus?.Equals(other.ToStatus) == true)) &&
                ((this.AppliedDate == null && other.AppliedDate == null) || (this.AppliedDate?.Equals(other.AppliedDate) == true)) &&
                ((this.RemainingAmount == null && other.RemainingAmount == null) || (this.RemainingAmount?.Equals(other.RemainingAmount) == true)) &&
                ((this.Applications == null && other.Applications == null) || (this.Applications?.Equals(other.Applications) == true)) &&
                ((this.OriginInvoices == null && other.OriginInvoices == null) || (this.OriginInvoices?.Equals(other.OriginInvoices) == true)) &&
                ((this.OriginCreditNoteUid == null && other.OriginCreditNoteUid == null) || (this.OriginCreditNoteUid?.Equals(other.OriginCreditNoteUid) == true)) &&
                ((this.OriginCreditNoteNumber == null && other.OriginCreditNoteNumber == null) || (this.OriginCreditNoteNumber?.Equals(other.OriginCreditNoteNumber) == true)) &&
                this.AmountInCents.Equals(other.AmountInCents) &&
                this.ApplyCredit.Equals(other.ApplyCredit) &&
                ((this.CreditNoteAttributes == null && other.CreditNoteAttributes == null) || (this.CreditNoteAttributes?.Equals(other.CreditNoteAttributes) == true)) &&
                this.PaymentId.Equals(other.PaymentId) &&
                this.RefundId.Equals(other.RefundId) &&
                this.IsAdvanceInvoice.Equals(other.IsAdvanceInvoice) &&
                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.CreditNoteNumber = {(this.CreditNoteNumber == null ? "null" : this.CreditNoteNumber)}");
            toStringOutput.Add($"this.CreditNoteUid = {(this.CreditNoteUid == null ? "null" : this.CreditNoteUid)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.TransactionTime = {this.TransactionTime}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"this.ConsolidatedInvoice = {(this.ConsolidatedInvoice == null ? "null" : this.ConsolidatedInvoice.ToString())}");
            toStringOutput.Add($"this.AppliedCreditNotes = {(this.AppliedCreditNotes == null ? "null" : $"[{string.Join(", ", this.AppliedCreditNotes)} ]")}");
            toStringOutput.Add($"this.DebitNoteNumber = {(this.DebitNoteNumber == null ? "null" : this.DebitNoteNumber)}");
            toStringOutput.Add($"this.DebitNoteUid = {(this.DebitNoteUid == null ? "null" : this.DebitNoteUid)}");
            toStringOutput.Add($"this.ConsolidationLevel = {this.ConsolidationLevel}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"this.TransactionId = {this.TransactionId}");
            toStringOutput.Add($"this.ParentInvoiceNumber = {(this.ParentInvoiceNumber == null ? "null" : this.ParentInvoiceNumber.ToString())}");
            toStringOutput.Add($"this.RemainingPrepaymentAmount = {(this.RemainingPrepaymentAmount == null ? "null" : this.RemainingPrepaymentAmount)}");
            toStringOutput.Add($"this.Prepayment = {this.Prepayment}");
            toStringOutput.Add($"this.External = {(this.External == null ? "null" : this.External.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.SequenceNumber = {(this.SequenceNumber == null ? "null" : this.SequenceNumber.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate.ToString())}");
            toStringOutput.Add($"this.DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"this.PaidDate = {(this.PaidDate == null ? "null" : this.PaidDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.ParentInvoiceId = {(this.ParentInvoiceId == null ? "null" : this.ParentInvoiceId.ToString())}");
            toStringOutput.Add($"this.CollectionMethod = {(this.CollectionMethod == null ? "null" : this.CollectionMethod.ToString())}");
            toStringOutput.Add($"this.PaymentInstructions = {(this.PaymentInstructions == null ? "null" : this.PaymentInstructions)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.ParentInvoiceUid = {(this.ParentInvoiceUid == null ? "null" : this.ParentInvoiceUid)}");
            toStringOutput.Add($"this.SubscriptionGroupId = {(this.SubscriptionGroupId == null ? "null" : this.SubscriptionGroupId.ToString())}");
            toStringOutput.Add($"this.GroupPrimarySubscriptionId = {(this.GroupPrimarySubscriptionId == null ? "null" : this.GroupPrimarySubscriptionId.ToString())}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductFamilyName = {(this.ProductFamilyName == null ? "null" : this.ProductFamilyName)}");
            toStringOutput.Add($"this.Seller = {(this.Seller == null ? "null" : this.Seller.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"this.RecipientEmails = {(this.RecipientEmails == null ? "null" : $"[{string.Join(", ", this.RecipientEmails)} ]")}");
            toStringOutput.Add($"this.NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"this.SubtotalAmount = {(this.SubtotalAmount == null ? "null" : this.SubtotalAmount)}");
            toStringOutput.Add($"this.DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");
            toStringOutput.Add($"this.CreditAmount = {(this.CreditAmount == null ? "null" : this.CreditAmount)}");
            toStringOutput.Add($"this.RefundAmount = {(this.RefundAmount == null ? "null" : this.RefundAmount)}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount)}");
            toStringOutput.Add($"this.DueAmount = {(this.DueAmount == null ? "null" : this.DueAmount)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"this.Taxes = {(this.Taxes == null ? "null" : $"[{string.Join(", ", this.Taxes)} ]")}");
            toStringOutput.Add($"this.Credits = {(this.Credits == null ? "null" : $"[{string.Join(", ", this.Credits)} ]")}");
            toStringOutput.Add($"this.Refunds = {(this.Refunds == null ? "null" : $"[{string.Join(", ", this.Refunds)} ]")}");
            toStringOutput.Add($"this.Payments = {(this.Payments == null ? "null" : $"[{string.Join(", ", this.Payments)} ]")}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.DisplaySettings = {(this.DisplaySettings == null ? "null" : this.DisplaySettings.ToString())}");
            toStringOutput.Add($"this.PublicUrl = {(this.PublicUrl == null ? "null" : this.PublicUrl)}");
            toStringOutput.Add($"this.PreviousBalanceData = {(this.PreviousBalanceData == null ? "null" : this.PreviousBalanceData.ToString())}");
            toStringOutput.Add($"this.ChargebackStatus = {this.ChargebackStatus}");
            toStringOutput.Add($"this.FromCollectionMethod = {(this.FromCollectionMethod == null ? "null" : this.FromCollectionMethod)}");
            toStringOutput.Add($"this.ToCollectionMethod = {(this.ToCollectionMethod == null ? "null" : this.ToCollectionMethod)}");
            toStringOutput.Add($"this.GatewayTransId = {(this.GatewayTransId == null ? "null" : this.GatewayTransId)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"FromStatus = {(this.FromStatus == null ? "null" : this.FromStatus.ToString())}");
            toStringOutput.Add($"ToStatus = {(this.ToStatus == null ? "null" : this.ToStatus.ToString())}");
            toStringOutput.Add($"this.AppliedDate = {(this.AppliedDate == null ? "null" : this.AppliedDate.ToString())}");
            toStringOutput.Add($"this.RemainingAmount = {(this.RemainingAmount == null ? "null" : this.RemainingAmount)}");
            toStringOutput.Add($"this.Applications = {(this.Applications == null ? "null" : $"[{string.Join(", ", this.Applications)} ]")}");
            toStringOutput.Add($"this.OriginInvoices = {(this.OriginInvoices == null ? "null" : $"[{string.Join(", ", this.OriginInvoices)} ]")}");
            toStringOutput.Add($"this.OriginCreditNoteUid = {(this.OriginCreditNoteUid == null ? "null" : this.OriginCreditNoteUid)}");
            toStringOutput.Add($"this.OriginCreditNoteNumber = {(this.OriginCreditNoteNumber == null ? "null" : this.OriginCreditNoteNumber)}");
            toStringOutput.Add($"this.AmountInCents = {this.AmountInCents}");
            toStringOutput.Add($"this.ApplyCredit = {this.ApplyCredit}");
            toStringOutput.Add($"this.CreditNoteAttributes = {(this.CreditNoteAttributes == null ? "null" : this.CreditNoteAttributes.ToString())}");
            toStringOutput.Add($"this.PaymentId = {this.PaymentId}");
            toStringOutput.Add($"this.RefundId = {this.RefundId}");
            toStringOutput.Add($"this.IsAdvanceInvoice = {this.IsAdvanceInvoice}");
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");

            base.ToString(toStringOutput);
        }
    }
}