// <copyright file="ProformaInvoicePreview.cs" company="APIMatic">
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
    /// ProformaInvoicePreview.
    /// </summary>
    public class ProformaInvoicePreview
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoicePreview"/> class.
        /// </summary>
        public ProformaInvoicePreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoicePreview"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="number">number.</param>
        /// <param name="sequenceNumber">sequence_number.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="deliveryDate">delivery_date.</param>
        /// <param name="status">status.</param>
        /// <param name="collectionMethod">collection_method.</param>
        /// <param name="paymentInstructions">payment_instructions.</param>
        /// <param name="currency">currency.</param>
        /// <param name="consolidationLevel">consolidation_level.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="productFamilyName">product_family_name.</param>
        /// <param name="role">role.</param>
        /// <param name="seller">seller.</param>
        /// <param name="customer">customer.</param>
        /// <param name="memo">memo.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="subtotalAmount">subtotal_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="creditAmount">credit_amount.</param>
        /// <param name="paidAmount">paid_amount.</param>
        /// <param name="refundAmount">refund_amount.</param>
        /// <param name="dueAmount">due_amount.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="credits">credits.</param>
        /// <param name="payments">payments.</param>
        /// <param name="customFields">custom_fields.</param>
        /// <param name="publicUrl">public_url.</param>
        public ProformaInvoicePreview(
            string uid = null,
            int? siteId = null,
            int? customerId = null,
            int? subscriptionId = null,
            string number = null,
            int? sequenceNumber = null,
            string createdAt = null,
            string deliveryDate = null,
            string status = null,
            string collectionMethod = null,
            string paymentInstructions = null,
            string currency = null,
            string consolidationLevel = null,
            string productName = null,
            string productFamilyName = null,
            string role = null,
            Models.InvoiceSeller seller = null,
            Models.InvoiceCustomer customer = null,
            string memo = null,
            Models.InvoiceAddress billingAddress = null,
            Models.InvoiceAddress shippingAddress = null,
            string subtotalAmount = null,
            string discountAmount = null,
            string taxAmount = null,
            string totalAmount = null,
            string creditAmount = null,
            string paidAmount = null,
            string refundAmount = null,
            string dueAmount = null,
            List<Models.InvoiceLineItem> lineItems = null,
            List<Models.ProformaInvoiceDiscount> discounts = null,
            List<Models.ProformaInvoiceTax> taxes = null,
            List<Models.ProformaInvoiceCredit> credits = null,
            List<Models.ProformaInvoicePayment> payments = null,
            List<Models.ProformaCustomField> customFields = null,
            string publicUrl = null)
        {
            this.Uid = uid;
            this.SiteId = siteId;
            this.CustomerId = customerId;
            this.SubscriptionId = subscriptionId;
            this.Number = number;
            this.SequenceNumber = sequenceNumber;
            this.CreatedAt = createdAt;
            this.DeliveryDate = deliveryDate;
            this.Status = status;
            this.CollectionMethod = collectionMethod;
            this.PaymentInstructions = paymentInstructions;
            this.Currency = currency;
            this.ConsolidationLevel = consolidationLevel;
            this.ProductName = productName;
            this.ProductFamilyName = productFamilyName;
            this.Role = role;
            this.Seller = seller;
            this.Customer = customer;
            this.Memo = memo;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.SubtotalAmount = subtotalAmount;
            this.DiscountAmount = discountAmount;
            this.TaxAmount = taxAmount;
            this.TotalAmount = totalAmount;
            this.CreditAmount = creditAmount;
            this.PaidAmount = paidAmount;
            this.RefundAmount = refundAmount;
            this.DueAmount = dueAmount;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Credits = credits;
            this.Payments = payments;
            this.CustomFields = customFields;
            this.PublicUrl = publicUrl;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets SiteId.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets SequenceNumber.
        /// </summary>
        [JsonProperty("sequence_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets DeliveryDate.
        /// </summary>
        [JsonProperty("delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CollectionMethod.
        /// </summary>
        [JsonProperty("collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Gets or sets PaymentInstructions.
        /// </summary>
        [JsonProperty("payment_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentInstructions { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets ConsolidationLevel.
        /// </summary>
        [JsonProperty("consolidation_level", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsolidationLevel { get; set; }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets ProductFamilyName.
        /// </summary>
        [JsonProperty("product_family_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductFamilyName { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

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
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets ShippingAddress.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets or sets SubtotalAmount.
        /// </summary>
        [JsonProperty("subtotal_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalAmount { get; set; }

        /// <summary>
        /// Gets or sets DiscountAmount.
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets TotalAmount.
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets CreditAmount.
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// Gets or sets PaidAmount.
        /// </summary>
        [JsonProperty("paid_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidAmount { get; set; }

        /// <summary>
        /// Gets or sets RefundAmount.
        /// </summary>
        [JsonProperty("refund_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// Gets or sets DueAmount.
        /// </summary>
        [JsonProperty("due_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DueAmount { get; set; }

        /// <summary>
        /// Gets or sets LineItems.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets Discounts.
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaInvoiceDiscount> Discounts { get; set; }

        /// <summary>
        /// Gets or sets Taxes.
        /// </summary>
        [JsonProperty("taxes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaInvoiceTax> Taxes { get; set; }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaInvoiceCredit> Credits { get; set; }

        /// <summary>
        /// Gets or sets Payments.
        /// </summary>
        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaInvoicePayment> Payments { get; set; }

        /// <summary>
        /// Gets or sets CustomFields.
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProformaCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets PublicUrl.
        /// </summary>
        [JsonProperty("public_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProformaInvoicePreview : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaInvoicePreview other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.SiteId == null && other.SiteId == null) || (this.SiteId?.Equals(other.SiteId) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.SequenceNumber == null && other.SequenceNumber == null) || (this.SequenceNumber?.Equals(other.SequenceNumber) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.DeliveryDate == null && other.DeliveryDate == null) || (this.DeliveryDate?.Equals(other.DeliveryDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.CollectionMethod == null && other.CollectionMethod == null) || (this.CollectionMethod?.Equals(other.CollectionMethod) == true)) &&
                ((this.PaymentInstructions == null && other.PaymentInstructions == null) || (this.PaymentInstructions?.Equals(other.PaymentInstructions) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.ConsolidationLevel == null && other.ConsolidationLevel == null) || (this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductFamilyName == null && other.ProductFamilyName == null) || (this.ProductFamilyName?.Equals(other.ProductFamilyName) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.Seller == null && other.Seller == null) || (this.Seller?.Equals(other.Seller) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.ShippingAddress == null && other.ShippingAddress == null) || (this.ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((this.SubtotalAmount == null && other.SubtotalAmount == null) || (this.SubtotalAmount?.Equals(other.SubtotalAmount) == true)) &&
                ((this.DiscountAmount == null && other.DiscountAmount == null) || (this.DiscountAmount?.Equals(other.DiscountAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.CreditAmount == null && other.CreditAmount == null) || (this.CreditAmount?.Equals(other.CreditAmount) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                ((this.RefundAmount == null && other.RefundAmount == null) || (this.RefundAmount?.Equals(other.RefundAmount) == true)) &&
                ((this.DueAmount == null && other.DueAmount == null) || (this.DueAmount?.Equals(other.DueAmount) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.Discounts == null && other.Discounts == null) || (this.Discounts?.Equals(other.Discounts) == true)) &&
                ((this.Taxes == null && other.Taxes == null) || (this.Taxes?.Equals(other.Taxes) == true)) &&
                ((this.Credits == null && other.Credits == null) || (this.Credits?.Equals(other.Credits) == true)) &&
                ((this.Payments == null && other.Payments == null) || (this.Payments?.Equals(other.Payments) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.PublicUrl == null && other.PublicUrl == null) || (this.PublicUrl?.Equals(other.PublicUrl) == true));
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
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.DeliveryDate = {(this.DeliveryDate == null ? "null" : this.DeliveryDate)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.CollectionMethod = {(this.CollectionMethod == null ? "null" : this.CollectionMethod)}");
            toStringOutput.Add($"this.PaymentInstructions = {(this.PaymentInstructions == null ? "null" : this.PaymentInstructions)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductFamilyName = {(this.ProductFamilyName == null ? "null" : this.ProductFamilyName)}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role)}");
            toStringOutput.Add($"this.Seller = {(this.Seller == null ? "null" : this.Seller.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"this.SubtotalAmount = {(this.SubtotalAmount == null ? "null" : this.SubtotalAmount)}");
            toStringOutput.Add($"this.DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount)}");
            toStringOutput.Add($"this.CreditAmount = {(this.CreditAmount == null ? "null" : this.CreditAmount)}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount)}");
            toStringOutput.Add($"this.RefundAmount = {(this.RefundAmount == null ? "null" : this.RefundAmount)}");
            toStringOutput.Add($"this.DueAmount = {(this.DueAmount == null ? "null" : this.DueAmount)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"this.Taxes = {(this.Taxes == null ? "null" : $"[{string.Join(", ", this.Taxes)} ]")}");
            toStringOutput.Add($"this.Credits = {(this.Credits == null ? "null" : $"[{string.Join(", ", this.Credits)} ]")}");
            toStringOutput.Add($"this.Payments = {(this.Payments == null ? "null" : $"[{string.Join(", ", this.Payments)} ]")}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.PublicUrl = {(this.PublicUrl == null ? "null" : this.PublicUrl)}");
        }
    }
}