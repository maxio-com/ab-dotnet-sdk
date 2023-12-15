// <copyright file="CreateInvoice.cs" company="APIMatic">
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
    /// CreateInvoice.
    /// </summary>
    public class CreateInvoice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoice"/> class.
        /// </summary>
        public CreateInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoice"/> class.
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
        /// <param name="status">status.</param>
        public CreateInvoice(
            List<Models.CreateInvoiceItem> lineItems = null,
            DateTime? issueDate = null,
            int? netTerms = null,
            string paymentInstructions = null,
            string memo = null,
            Models.CreateInvoiceAddress sellerAddress = null,
            Models.CreateInvoiceAddress billingAddress = null,
            Models.CreateInvoiceAddress shippingAddress = null,
            List<Models.CreateInvoiceCoupon> coupons = null,
            Models.CreateInvoiceStatus? status = Models.CreateInvoiceStatus.Open)
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
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets LineItems.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateInvoiceItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets IssueDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// By default, invoices will be created with a due date matching the date of invoice creation. If a different due date is desired, the net_terms parameter can be sent indicating the number of days in advance the due date should be.
        /// </summary>
        [JsonProperty("net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetTerms { get; set; }

        /// <summary>
        /// Gets or sets PaymentInstructions.
        /// </summary>
        [JsonProperty("payment_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentInstructions { get; set; }

        /// <summary>
        /// A custom memo can be sent to override the site's default.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Overrides the defaults for the site
        /// </summary>
        [JsonProperty("seller_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInvoiceAddress SellerAddress { get; set; }

        /// <summary>
        /// Overrides the default for the customer
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInvoiceAddress BillingAddress { get; set; }

        /// <summary>
        /// Overrides the default for the customer
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInvoiceAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets Coupons.
        /// </summary>
        [JsonProperty("coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateInvoiceCoupon> Coupons { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateInvoiceStatus? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateInvoice : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateInvoice other &&                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.IssueDate == null && other.IssueDate == null) || (this.IssueDate?.Equals(other.IssueDate) == true)) &&
                ((this.NetTerms == null && other.NetTerms == null) || (this.NetTerms?.Equals(other.NetTerms) == true)) &&
                ((this.PaymentInstructions == null && other.PaymentInstructions == null) || (this.PaymentInstructions?.Equals(other.PaymentInstructions) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.SellerAddress == null && other.SellerAddress == null) || (this.SellerAddress?.Equals(other.SellerAddress) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.ShippingAddress == null && other.ShippingAddress == null) || (this.ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((this.Coupons == null && other.Coupons == null) || (this.Coupons?.Equals(other.Coupons) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.IssueDate = {(this.IssueDate == null ? "null" : this.IssueDate.ToString())}");
            toStringOutput.Add($"this.NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"this.PaymentInstructions = {(this.PaymentInstructions == null ? "null" : this.PaymentInstructions)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.SellerAddress = {(this.SellerAddress == null ? "null" : this.SellerAddress.ToString())}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"this.Coupons = {(this.Coupons == null ? "null" : $"[{string.Join(", ", this.Coupons)} ]")}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}