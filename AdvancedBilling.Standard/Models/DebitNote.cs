// <copyright file="DebitNote.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
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

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// DebitNote.
    /// </summary>
    public class DebitNote : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitNote"/> class.
        /// </summary>
        public DebitNote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebitNote"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="number">number.</param>
        /// <param name="sequenceNumber">sequence_number.</param>
        /// <param name="originCreditNoteUid">origin_credit_note_uid.</param>
        /// <param name="originCreditNoteNumber">origin_credit_note_number.</param>
        /// <param name="issueDate">issue_date.</param>
        /// <param name="appliedDate">applied_date.</param>
        /// <param name="dueDate">due_date.</param>
        /// <param name="status">status.</param>
        /// <param name="memo">memo.</param>
        /// <param name="role">role.</param>
        /// <param name="currency">currency.</param>
        /// <param name="seller">seller.</param>
        /// <param name="customer">customer.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="refunds">refunds.</param>
        public DebitNote(
            string uid = null,
            int? siteId = null,
            int? customerId = null,
            int? subscriptionId = null,
            int? number = null,
            int? sequenceNumber = null,
            string originCreditNoteUid = null,
            string originCreditNoteNumber = null,
            DateTime? issueDate = null,
            DateTime? appliedDate = null,
            DateTime? dueDate = null,
            Models.DebitNoteStatus? status = null,
            string memo = null,
            Models.DebitNoteRole? role = null,
            string currency = null,
            Models.InvoiceSeller seller = null,
            Models.InvoiceCustomer customer = null,
            Models.InvoiceAddress billingAddress = null,
            Models.InvoiceAddress shippingAddress = null,
            List<Models.CreditNoteLineItem> lineItems = null,
            List<Models.InvoiceDiscount> discounts = null,
            List<Models.InvoiceTax> taxes = null,
            List<Models.InvoiceRefund> refunds = null)
        {
            this.Uid = uid;
            this.SiteId = siteId;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.Number = number;
            this.SequenceNumber = sequenceNumber;
            this.OriginCreditNoteUid = originCreditNoteUid;
            this.OriginCreditNoteNumber = originCreditNoteNumber;
            this.IssueDate = issueDate;
            this.AppliedDate = appliedDate;
            this.DueDate = dueDate;
            this.Status = status;
            this.Memo = memo;
            this.Role = role;
            this.Currency = currency;
            this.Seller = seller;
            this.Customer = customer;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Refunds = refunds;
        }

        /// <summary>
        /// Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// ID of the site to which the debit note belongs.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// ID of the customer to which the debit note belongs.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// ID of the subscription that generated the debit note.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// A unique, identifier that appears on the debit note and in places it is referenced.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// A monotonically increasing number assigned to debit notes as they are created.
        /// </summary>
        [JsonProperty("sequence_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNumber { get; set; }

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
        /// Date the document was issued to the customer. This is the date that the document was made available for payment.
        /// The format is "YYYY-MM-DD".
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Debit notes are applied to invoices to offset invoiced amounts - they adjust the amount due. This field is the date the debit note document became fully applied to the invoice.
        /// The format is "YYYY-MM-DD".
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("applied_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AppliedDate { get; set; }

        /// <summary>
        /// Date the document is due for payment. The format is "YYYY-MM-DD".
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Current status of the debit note.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DebitNoteStatus? Status { get; set; }

        /// <summary>
        /// The memo printed on debit note, which is a description of the reason for the debit.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// The role of the debit note.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DebitNoteRole? Role { get; set; }

        /// <summary>
        /// The ISO 4217 currency code (3 character string) representing the currency of the credit note amount fields.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Information about the seller (merchant) listed on the masthead of the debit note.
        /// </summary>
        [JsonProperty("seller", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceSeller Seller { get; set; }

        /// <summary>
        /// Information about the customer who is owner or recipient the debited subscription.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceCustomer Customer { get; set; }

        /// <summary>
        /// The billing address of the debited subscription.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress BillingAddress { get; set; }

        /// <summary>
        /// The shipping address of the debited subscription.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress ShippingAddress { get; set; }

        /// <summary>
        /// Line items on the debit note.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreditNoteLineItem> LineItems { get; set; }

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
        /// Gets or sets Refunds.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceRefund> Refunds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DebitNote : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DebitNote other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.SiteId == null && other.SiteId == null ||
                 this.SiteId?.Equals(other.SiteId) == true) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.Number == null && other.Number == null ||
                 this.Number?.Equals(other.Number) == true) &&
                (this.SequenceNumber == null && other.SequenceNumber == null ||
                 this.SequenceNumber?.Equals(other.SequenceNumber) == true) &&
                (this.OriginCreditNoteUid == null && other.OriginCreditNoteUid == null ||
                 this.OriginCreditNoteUid?.Equals(other.OriginCreditNoteUid) == true) &&
                (this.OriginCreditNoteNumber == null && other.OriginCreditNoteNumber == null ||
                 this.OriginCreditNoteNumber?.Equals(other.OriginCreditNoteNumber) == true) &&
                (this.IssueDate == null && other.IssueDate == null ||
                 this.IssueDate?.Equals(other.IssueDate) == true) &&
                (this.AppliedDate == null && other.AppliedDate == null ||
                 this.AppliedDate?.Equals(other.AppliedDate) == true) &&
                (this.DueDate == null && other.DueDate == null ||
                 this.DueDate?.Equals(other.DueDate) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Role == null && other.Role == null ||
                 this.Role?.Equals(other.Role) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Seller == null && other.Seller == null ||
                 this.Seller?.Equals(other.Seller) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.ShippingAddress == null && other.ShippingAddress == null ||
                 this.ShippingAddress?.Equals(other.ShippingAddress) == true) &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                (this.Discounts == null && other.Discounts == null ||
                 this.Discounts?.Equals(other.Discounts) == true) &&
                (this.Taxes == null && other.Taxes == null ||
                 this.Taxes?.Equals(other.Taxes) == true) &&
                (this.Refunds == null && other.Refunds == null ||
                 this.Refunds?.Equals(other.Refunds) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"Number = {(this.Number == null ? "null" : this.Number.ToString())}");
            toStringOutput.Add($"SequenceNumber = {(this.SequenceNumber == null ? "null" : this.SequenceNumber.ToString())}");
            toStringOutput.Add($"OriginCreditNoteUid = {this.OriginCreditNoteUid ?? "null"}");
            toStringOutput.Add($"OriginCreditNoteNumber = {this.OriginCreditNoteNumber ?? "null"}");
            toStringOutput.Add($"IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate.ToString())}");
            toStringOutput.Add($"AppliedDate = {(this.AppliedDate == null ? "null" : this.AppliedDate.ToString())}");
            toStringOutput.Add($"DueDate = {(this.DueDate == null ? "null" : this.DueDate.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Seller = {(this.Seller == null ? "null" : this.Seller.ToString())}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"Taxes = {(this.Taxes == null ? "null" : $"[{string.Join(", ", this.Taxes)} ]")}");
            toStringOutput.Add($"Refunds = {(this.Refunds == null ? "null" : $"[{string.Join(", ", this.Refunds)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}