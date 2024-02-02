// <copyright file="CreditNote.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreditNote.
    /// </summary>
    public class CreditNote
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNote"/> class.
        /// </summary>
        public CreditNote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNote"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="number">number.</param>
        /// <param name="sequenceNumber">sequence_number.</param>
        /// <param name="issueDate">issue_date.</param>
        /// <param name="appliedDate">applied_date.</param>
        /// <param name="status">status.</param>
        /// <param name="currency">currency.</param>
        /// <param name="memo">memo.</param>
        /// <param name="seller">seller.</param>
        /// <param name="customer">customer.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="subtotalAmount">subtotal_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        /// <param name="remainingAmount">remaining_amount.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="applications">applications.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="originInvoices">origin_invoices.</param>
        public CreditNote(
            string uid = null,
            int? siteId = null,
            int? customerId = null,
            int? subscriptionId = null,
            string number = null,
            int? sequenceNumber = null,
            DateTime? issueDate = null,
            DateTime? appliedDate = null,
            Models.CreditNoteStatus? status = null,
            string currency = null,
            string memo = null,
            Models.InvoiceSeller seller = null,
            Models.InvoiceCustomer customer = null,
            Models.InvoiceAddress billingAddress = null,
            Models.InvoiceAddress shippingAddress = null,
            string subtotalAmount = null,
            string discountAmount = null,
            string taxAmount = null,
            string totalAmount = null,
            string appliedAmount = null,
            string remainingAmount = null,
            List<Models.CreditNoteLineItem> lineItems = null,
            List<Models.InvoiceDiscount> discounts = null,
            List<Models.InvoiceTax> taxes = null,
            List<Models.CreditNoteApplication> applications = null,
            List<Models.InvoiceRefund> refunds = null,
            List<Models.OriginInvoice> originInvoices = null)
        {
            this.Uid = uid;
            this.SiteId = siteId;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.Number = number;
            this.SequenceNumber = sequenceNumber;
            this.IssueDate = issueDate;
            this.AppliedDate = appliedDate;
            this.Status = status;
            this.Currency = currency;
            this.Memo = memo;
            this.Seller = seller;
            this.Customer = customer;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.SubtotalAmount = subtotalAmount;
            this.DiscountAmount = discountAmount;
            this.TaxAmount = taxAmount;
            this.TotalAmount = totalAmount;
            this.AppliedAmount = appliedAmount;
            this.RemainingAmount = remainingAmount;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Applications = applications;
            this.Refunds = refunds;
            this.OriginInvoices = originInvoices;
        }

        /// <summary>
        /// Unique identifier for the credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// ID of the site to which the credit note belongs.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// ID of the customer to which the credit note belongs.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// ID of the subscription that generated the credit note.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// A unique, identifying string that appears on the credit note and in places it is referenced.
        /// While the UID is long and not appropriate to show to customers, the number is usually shorter and consumable by the customer and the merchant alike.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// A monotonically increasing number assigned to credit notes as they are created.  This number is unique within a site and can be used to sort and order credit notes.
        /// </summary>
        [JsonProperty("sequence_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Date the credit note was issued to the customer.  This is the date that the credit was made available for application, and may come before it is fully applied.
        /// The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Credit notes are applied to invoices to offset invoiced amounts - they reduce the amount due. This field is the date the credit note became fully applied to invoices.
        /// If the credit note has been partially applied, this field will not have a value until it has been fully applied.
        /// The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("applied_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AppliedDate { get; set; }

        /// <summary>
        /// Current status of the credit note.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditNoteStatus? Status { get; set; }

        /// <summary>
        /// The ISO 4217 currency code (3 character string) representing the currency of the credit note amount fields.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// The memo printed on credit note, which is a description of the reason for the credit.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Information about the seller (merchant) listed on the masthead of the credit note.
        /// </summary>
        [JsonProperty("seller", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceSeller Seller { get; set; }

        /// <summary>
        /// Information about the customer who is owner or recipient the credited subscription.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceCustomer Customer { get; set; }

        /// <summary>
        /// The billing address of the credit subscription.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress BillingAddress { get; set; }

        /// <summary>
        /// The shipping address of the credited subscription.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress ShippingAddress { get; set; }

        /// <summary>
        /// Subtotal of the credit note, which is the sum of all line items before discounts or taxes. Note that this is a positive amount representing the credit back to the customer.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("subtotal_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalAmount { get; set; }

        /// <summary>
        /// Total discount applied to the credit note. Note that this is a positive amount representing the discount amount being credited back to the customer (i.e. a credit on an earlier discount). For example, if the original purchase was $1.00 and the original discount was $0.10, a credit of $0.50 of the original purchase (half) would have a discount credit of $0.05 (also half).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Total tax of the credit note. Note that this is a positive amount representing a previously taxex amount being credited back to the customer (i.e. a credit of an earlier tax). For example, if the original purchase was $1.00 and the original tax was $0.10, a credit of $0.50 of the original purchase (half) would also have a tax credit of $0.05 (also half).
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// The credit note total, which is `subtotal_amount - discount_amount + tax_amount`.'
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// The amount of the credit note that has already been applied to invoices.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <summary>
        /// The amount of the credit note remaining to be applied to invoices, which is `total_amount - applied_amount`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("remaining_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingAmount { get; set; }

        /// <summary>
        /// Line items on the credit note.
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
        /// Gets or sets Applications.
        /// </summary>
        [JsonProperty("applications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreditNoteApplication> Applications { get; set; }

        /// <summary>
        /// Gets or sets Refunds.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceRefund> Refunds { get; set; }

        /// <summary>
        /// An array of origin invoices for the credit note. Learn more about [Origin Invoice from our docs](https://chargify.zendesk.com/hc/en-us/articles/4407753036699#origin-invoices)
        /// </summary>
        [JsonProperty("origin_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OriginInvoice> OriginInvoices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreditNote : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreditNote other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.SiteId == null && other.SiteId == null) || (this.SiteId?.Equals(other.SiteId) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.SequenceNumber == null && other.SequenceNumber == null) || (this.SequenceNumber?.Equals(other.SequenceNumber) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.AppliedDate == null && other.AppliedDate == null) || (this.AppliedDate?.Equals(other.AppliedDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Seller == null && other.Seller == null) || (this.Seller?.Equals(other.Seller) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.ShippingAddress == null && other.ShippingAddress == null) || (this.ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((this.SubtotalAmount == null && other.SubtotalAmount == null) || (this.SubtotalAmount?.Equals(other.SubtotalAmount) == true)) &&
                ((this.DiscountAmount == null && other.DiscountAmount == null) || (this.DiscountAmount?.Equals(other.DiscountAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true)) &&
                ((this.RemainingAmount == null && other.RemainingAmount == null) || (this.RemainingAmount?.Equals(other.RemainingAmount) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Taxes == null && other.Taxes == null) || (this.Taxes?.Equals(other.Taxes) == true)) &&
                ((this.Applications == null && other.Applications == null) || (this.Applications?.Equals(other.Applications) == true)) &&
                ((this.Refunds == null && other.Refunds == null) || (this.Refunds?.Equals(other.Refunds) == true)) &&
                ((this.OriginInvoices == null && other.OriginInvoices == null) || (this.OriginInvoices?.Equals(other.OriginInvoices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.SequenceNumber = {(this.SequenceNumber == null ? "null" : this.SequenceNumber.ToString())}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate.ToString())}");
            toStringOutput.Add($"this.AppliedDate = {(this.AppliedDate == null ? "null" : this.AppliedDate.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Seller = {(this.Seller == null ? "null" : this.Seller.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"this.SubtotalAmount = {(this.SubtotalAmount == null ? "null" : this.SubtotalAmount)}");
            toStringOutput.Add($"this.DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
            toStringOutput.Add($"this.RemainingAmount = {(this.RemainingAmount == null ? "null" : this.RemainingAmount)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"this.Taxes = {(this.Taxes == null ? "null" : $"[{string.Join(", ", this.Taxes)} ]")}");
            toStringOutput.Add($"this.Applications = {(this.Applications == null ? "null" : $"[{string.Join(", ", this.Applications)} ]")}");
            toStringOutput.Add($"this.Refunds = {(this.Refunds == null ? "null" : $"[{string.Join(", ", this.Refunds)} ]")}");
            toStringOutput.Add($"this.OriginInvoices = {(this.OriginInvoices == null ? "null" : $"[{string.Join(", ", this.OriginInvoices)} ]")}");
        }
    }
}