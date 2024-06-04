// <copyright file="Invoice.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Invoice.
    /// </summary>
    public class Invoice : BaseModel
    {
        private DateTime? paidDate;
        private int? parentInvoiceId;
        private string parentInvoiceUid;
        private int? subscriptionGroupId;
        private int? parentInvoiceNumber;
        private int? groupPrimarySubscriptionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "paid_date", false },
            { "parent_invoice_id", false },
            { "parent_invoice_uid", false },
            { "subscription_group_id", false },
            { "parent_invoice_number", false },
            { "group_primary_subscription_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice"/> class.
        /// </summary>
        public Invoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="uid">uid.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="number">number.</param>
        /// <param name="sequenceNumber">sequence_number.</param>
        /// <param name="transactionTime">transaction_time.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="issueDate">issue_date.</param>
        /// <param name="dueDate">due_date.</param>
        /// <param name="paidDate">paid_date.</param>
        /// <param name="status">status.</param>
        /// <param name="role">role.</param>
        /// <param name="parentInvoiceId">parent_invoice_id.</param>
        /// <param name="collectionMethod">collection_method.</param>
        /// <param name="paymentInstructions">payment_instructions.</param>
        /// <param name="currency">currency.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="parentInvoiceUid">parent_invoice_uid.</param>
        /// <param name="subscriptionGroupId">subscription_group_id.</param>
        /// <param name="parentInvoiceNumber">parent_invoice_number.</param>
        /// <param name="groupPrimarySubscriptionId">group_primary_subscription_id.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="productFamilyName">product_family_name.</param>
        /// <param name="seller">seller.</param>
        /// <param name="customer">customer.</param>
        /// <param name="payer">payer.</param>
        /// <param name="recipientEmails">recipient_emails.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="memo">memo.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="subtotalAmount">subtotal_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="creditAmount">credit_amount.</param>
        /// <param name="refundAmount">refund_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="dueAmount">due_amount.</param>
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
        public Invoice(
            long? id = null,
            string uid = null,
            int? siteId = null,
            int? customerId = null,
            int? subscriptionId = null,
            string number = null,
            int? sequenceNumber = null,
            DateTimeOffset? transactionTime = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            DateTime? issueDate = null,
            DateTime? dueDate = null,
            DateTime? paidDate = null,
            Models.InvoiceStatus? status = null,
            Models.InvoiceRole? role = null,
            int? parentInvoiceId = null,
            Models.CollectionMethod? collectionMethod = null,
            string paymentInstructions = null,
            string currency = null,
            Models.InvoiceConsolidationLevel? consolidationLevel = null,
            string parentInvoiceUid = null,
            int? subscriptionGroupId = null,
            int? parentInvoiceNumber = null,
            int? groupPrimarySubscriptionId = null,
            string productName = null,
            string productFamilyName = null,
            Models.InvoiceSeller seller = null,
            Models.InvoiceCustomer customer = null,
            Models.InvoicePayer payer = null,
            List<string> recipientEmails = null,
            int? netTerms = null,
            string memo = null,
            Models.InvoiceAddress billingAddress = null,
            Models.InvoiceAddress shippingAddress = null,
            string subtotalAmount = null,
            string discountAmount = null,
            string taxAmount = null,
            string totalAmount = null,
            string creditAmount = null,
            string refundAmount = null,
            string paidAmount = null,
            string dueAmount = null,
            List<Models.InvoiceLineItem> lineItems = null,
            List<Models.InvoiceDiscount> discounts = null,
            List<Models.InvoiceTax> taxes = null,
            List<Models.InvoiceCredit> credits = null,
            List<Models.InvoiceRefund> refunds = null,
            List<Models.InvoicePayment> payments = null,
            List<Models.InvoiceCustomField> customFields = null,
            Models.InvoiceDisplaySettings displaySettings = null,
            string publicUrl = null,
            Models.InvoicePreviousBalance previousBalanceData = null)
        {
            this.Id = id;
            this.Uid = uid;
            this.SiteId = siteId;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.Number = number;
            this.SequenceNumber = sequenceNumber;
            this.TransactionTime = transactionTime;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IssueDate = issueDate;
            this.DueDate = dueDate;
            if (paidDate != null)
            {
                this.PaidDate = paidDate;
            }

            this.Status = status;
            this.Role = role;
            if (parentInvoiceId != null)
            {
                this.ParentInvoiceId = parentInvoiceId;
            }

            this.CollectionMethod = collectionMethod;
            this.PaymentInstructions = paymentInstructions;
            this.Currency = currency;
            this.ConsolidationLevel = consolidationLevel;
            if (parentInvoiceUid != null)
            {
                this.ParentInvoiceUid = parentInvoiceUid;
            }

            if (subscriptionGroupId != null)
            {
                this.SubscriptionGroupId = subscriptionGroupId;
            }

            if (parentInvoiceNumber != null)
            {
                this.ParentInvoiceNumber = parentInvoiceNumber;
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
            this.Memo = memo;
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
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// Unique identifier for the invoice. It is generated automatically by Chargify and has the prefix "inv_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

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
        /// Gets or sets TransactionTime.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("transaction_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TransactionTime { get; set; }

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
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceRole? Role { get; set; }

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
        /// Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:
        /// * "none": A normal invoice with no consolidation.
        /// * "child": An invoice segment which has been combined into a consolidated invoice.
        /// * "parent": A consolidated invoice, whose contents are composed of invoice segments.
        /// "Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.
        /// See also the [invoice consolidation documentation](https://chargify.zendesk.com/hc/en-us/articles/4407746391835).
        /// </summary>
        [JsonProperty("consolidation_level", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceConsolidationLevel? ConsolidationLevel { get; set; }

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
        /// The memo printed on invoices of any collection type.  This message is in control of the merchant.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The invoice billing address.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress BillingAddress { get; set; }

        /// <summary>
        /// The invoice shipping address.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress ShippingAddress { get; set; }

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
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// The amount of credit (from credit notes) applied to this invoice.
        /// Credits offset the amount due from the customer.
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// Gets or sets RefundAmount.
        /// </summary>
        [JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// The amount paid on the invoice by the customer.
        /// </summary>
        [JsonProperty("paid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidAmount { get; set; }

        /// <summary>
        /// Amount due on the invoice, which is `total_amount - credit_amount - paid_amount`.
        /// </summary>
        [JsonProperty("due_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DueAmount { get; set; }

        /// <summary>
        /// Line items on the invoice.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceLineItem> LineItems { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Invoice : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetParentInvoiceNumber()
        {
            this.shouldSerialize["parent_invoice_number"] = false;
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
        public bool ShouldSerializeParentInvoiceNumber()
        {
            return this.shouldSerialize["parent_invoice_number"];
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
            return obj is Invoice other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.SiteId == null && other.SiteId == null) || (this.SiteId?.Equals(other.SiteId) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.SequenceNumber == null && other.SequenceNumber == null) || (this.SequenceNumber?.Equals(other.SequenceNumber) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.DueDate == null && other.DueDate == null) || (this.DueDate?.Equals(other.DueDate) == true)) &&
                ((this.PaidDate == null && other.PaidDate == null) || (this.PaidDate?.Equals(other.PaidDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.ParentInvoiceId == null && other.ParentInvoiceId == null) || (this.ParentInvoiceId?.Equals(other.ParentInvoiceId) == true)) &&
                ((this.CollectionMethod == null && other.CollectionMethod == null) || (this.CollectionMethod?.Equals(other.CollectionMethod) == true)) &&
                ((this.PaymentInstructions == null && other.PaymentInstructions == null) || (this.PaymentInstructions?.Equals(other.PaymentInstructions) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.ConsolidationLevel == null && other.ConsolidationLevel == null) || (this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true)) &&
                ((this.ParentInvoiceUid == null && other.ParentInvoiceUid == null) || (this.ParentInvoiceUid?.Equals(other.ParentInvoiceUid) == true)) &&
                ((this.SubscriptionGroupId == null && other.SubscriptionGroupId == null) || (this.SubscriptionGroupId?.Equals(other.SubscriptionGroupId) == true)) &&
                ((this.ParentInvoiceNumber == null && other.ParentInvoiceNumber == null) || (this.ParentInvoiceNumber?.Equals(other.ParentInvoiceNumber) == true)) &&
                ((this.GroupPrimarySubscriptionId == null && other.GroupPrimarySubscriptionId == null) || (this.GroupPrimarySubscriptionId?.Equals(other.GroupPrimarySubscriptionId) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductFamilyName == null && other.ProductFamilyName == null) || (this.ProductFamilyName?.Equals(other.ProductFamilyName) == true)) &&
                ((this.Seller == null && other.Seller == null) || (this.Seller?.Equals(other.Seller) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                ((this.RecipientEmails == null && other.RecipientEmails == null) || (this.RecipientEmails?.Equals(other.RecipientEmails) == true)) &&
                ((this.NetTerms == null && other.NetTerms == null) || (this.NetTerms?.Equals(other.NetTerms) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
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
                ((this.PreviousBalanceData == null && other.PreviousBalanceData == null) || (this.PreviousBalanceData?.Equals(other.PreviousBalanceData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.SequenceNumber = {(this.SequenceNumber == null ? "null" : this.SequenceNumber.ToString())}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate.ToString())}");
            toStringOutput.Add($"this.DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"this.PaidDate = {(this.PaidDate == null ? "null" : this.PaidDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"this.ParentInvoiceId = {(this.ParentInvoiceId == null ? "null" : this.ParentInvoiceId.ToString())}");
            toStringOutput.Add($"this.CollectionMethod = {(this.CollectionMethod == null ? "null" : this.CollectionMethod.ToString())}");
            toStringOutput.Add($"this.PaymentInstructions = {(this.PaymentInstructions == null ? "null" : this.PaymentInstructions)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel.ToString())}");
            toStringOutput.Add($"this.ParentInvoiceUid = {(this.ParentInvoiceUid == null ? "null" : this.ParentInvoiceUid)}");
            toStringOutput.Add($"this.SubscriptionGroupId = {(this.SubscriptionGroupId == null ? "null" : this.SubscriptionGroupId.ToString())}");
            toStringOutput.Add($"this.ParentInvoiceNumber = {(this.ParentInvoiceNumber == null ? "null" : this.ParentInvoiceNumber.ToString())}");
            toStringOutput.Add($"this.GroupPrimarySubscriptionId = {(this.GroupPrimarySubscriptionId == null ? "null" : this.GroupPrimarySubscriptionId.ToString())}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductFamilyName = {(this.ProductFamilyName == null ? "null" : this.ProductFamilyName)}");
            toStringOutput.Add($"this.Seller = {(this.Seller == null ? "null" : this.Seller.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"this.RecipientEmails = {(this.RecipientEmails == null ? "null" : $"[{string.Join(", ", this.RecipientEmails)} ]")}");
            toStringOutput.Add($"this.NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
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

            base.ToString(toStringOutput);
        }
    }
}