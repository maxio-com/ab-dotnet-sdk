// <copyright file="UpdateInvoice.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateInvoice.
    /// </summary>
    public class UpdateInvoice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoice"/> class.
        /// </summary>
        public UpdateInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInvoice"/> class.
        /// </summary>
        /// <param name="lineItems">line_items.</param>
        /// <param name="issueDate">issue_date.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="paymentInstructions">payment_instructions.</param>
        /// <param name="memo">memo.</param>
        /// <param name="sellerAddress">seller_address.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="coupons">coupons.</param>
        public UpdateInvoice(
            List<Models.UpdateInvoiceItem> lineItems = null,
            DateTime? issueDate = null,
            int? netTerms = null,
            string paymentInstructions = null,
            string memo = null,
            Models.CreateInvoiceAddress sellerAddress = null,
            Models.CreateInvoiceAddress billingAddress = null,
            Models.CreateInvoiceAddress shippingAddress = null,
            List<Models.CreateInvoiceCoupon> coupons = null)
        {
            this.LineItems = lineItems;
            this.IssueDate = issueDate;
            this.NetTerms = netTerms;
            this.PaymentInstructions = paymentInstructions;
            this.Memo = memo;
            this.SellerAddress = sellerAddress;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.Coupons = coupons;
        }

        /// <summary>
        /// Line item changes to apply. Line items without a `uid` are added, line items with a `uid` are updated, and line items with a `uid` and `_destroy` set to `true` are removed. Existing line items not referenced in the array remain unchanged.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateInvoiceItem> LineItems { get; set; }

        /// <summary>
        /// New issue date for the invoice (format YYYY-MM-DD). This date is interpreted and validated in your site's time zone. It must be today or a date in the past — future dates are not accepted. The due date is recalculated from the issue date and net terms.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Number of days after the issue date on which the invoice is due. The due date is recalculated when net terms or the issue date change.
        /// </summary>
        [JsonProperty("net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetTerms { get; set; }

        /// <summary>
        /// Custom payment instructions displayed on the invoice.
        /// </summary>
        [JsonProperty("payment_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentInstructions { get; set; }

        /// <summary>
        /// A custom memo displayed on the invoice.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Replaces the seller address on the invoice
        /// </summary>
        [JsonProperty("seller_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInvoiceAddress SellerAddress { get; set; }

        /// <summary>
        /// Replaces the billing address on the invoice
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInvoiceAddress BillingAddress { get; set; }

        /// <summary>
        /// Replaces the shipping address on the invoice
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInvoiceAddress ShippingAddress { get; set; }

        /// <summary>
        /// When present, replaces all discounts currently applied to the invoice. Send an empty array to remove all discounts.
        /// </summary>
        [JsonProperty("coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateInvoiceCoupon> Coupons { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateInvoice : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateInvoice other &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                (this.IssueDate == null && other.IssueDate == null ||
                 this.IssueDate?.Equals(other.IssueDate) == true) &&
                (this.NetTerms == null && other.NetTerms == null ||
                 this.NetTerms?.Equals(other.NetTerms) == true) &&
                (this.PaymentInstructions == null && other.PaymentInstructions == null ||
                 this.PaymentInstructions?.Equals(other.PaymentInstructions) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.SellerAddress == null && other.SellerAddress == null ||
                 this.SellerAddress?.Equals(other.SellerAddress) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.ShippingAddress == null && other.ShippingAddress == null ||
                 this.ShippingAddress?.Equals(other.ShippingAddress) == true) &&
                (this.Coupons == null && other.Coupons == null ||
                 this.Coupons?.Equals(other.Coupons) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate.ToString())}");
            toStringOutput.Add($"NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"PaymentInstructions = {this.PaymentInstructions ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"SellerAddress = {(this.SellerAddress == null ? "null" : this.SellerAddress.ToString())}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"Coupons = {(this.Coupons == null ? "null" : $"[{string.Join(", ", this.Coupons)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}