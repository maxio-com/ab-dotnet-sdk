// <copyright file="ProformaInvoice.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// ProformaInvoice.
    /// </summary>
    public class ProformaInvoice : BaseModel
    {
        private int? customerId;
        private int? subscriptionId;
        private int? number;
        private int? sequenceNumber;
        private string publicUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "customer_id", false },
            { "subscription_id", false },
            { "number", false },
            { "sequence_number", false },
            { "public_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoice"/> class.
        /// </summary>
        public ProformaInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaInvoice"/> class.
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
        public ProformaInvoice(
            string uid = null,
            int? siteId = null,
            int? customerId = null,
            int? subscriptionId = null,
            int? number = null,
            int? sequenceNumber = null,
            DateTimeOffset? createdAt = null,
            DateTime? deliveryDate = null,
            Models.ProformaInvoiceStatus? status = null,
            Models.CollectionMethod? collectionMethod = null,
            string paymentInstructions = null,
            string currency = null,
            Models.InvoiceConsolidationLevel? consolidationLevel = null,
            string productName = null,
            string productFamilyName = null,
            Models.ProformaInvoiceRole? role = null,
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
            List<Models.InvoiceCustomField> customFields = null,
            string publicUrl = null)
        {
            this.Uid = uid;
            this.SiteId = siteId;

            if (customerId != null)
            {
                this.CustomerId = customerId;
            }

            if (subscriptionId != null)
            {
                this.SubscriptionId = subscriptionId;
            }

            if (number != null)
            {
                this.Number = number;
            }

            if (sequenceNumber != null)
            {
                this.SequenceNumber = sequenceNumber;
            }
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

            if (publicUrl != null)
            {
                this.PublicUrl = publicUrl;
            }
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
        [JsonProperty("customer_id")]
        public int? CustomerId
        {
            get
            {
                return this.customerId;
            }

            set
            {
                this.shouldSerialize["customer_id"] = true;
                this.customerId = value;
            }
        }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public int? SubscriptionId
        {
            get
            {
                return this.subscriptionId;
            }

            set
            {
                this.shouldSerialize["subscription_id"] = true;
                this.subscriptionId = value;
            }
        }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number")]
        public int? Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.shouldSerialize["number"] = true;
                this.number = value;
            }
        }

        /// <summary>
        /// Gets or sets SequenceNumber.
        /// </summary>
        [JsonProperty("sequence_number")]
        public int? SequenceNumber
        {
            get
            {
                return this.sequenceNumber;
            }

            set
            {
                this.shouldSerialize["sequence_number"] = true;
                this.sequenceNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets DeliveryDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("delivery_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProformaInvoiceStatus? Status { get; set; }

        /// <summary>
        /// The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`.
        /// </summary>
        [JsonProperty("collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CollectionMethod? CollectionMethod { get; set; }

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
        /// Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:
        /// * "none": A normal invoice with no consolidation.
        /// * "child": An invoice segment which has been combined into a consolidated invoice.
        /// * "parent": A consolidated invoice, whose contents are composed of invoice segments.
        /// "Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.
        /// See also the [invoice consolidation documentation](https://maxio.zendesk.com/hc/en-us/articles/24252269909389-Invoice-Consolidation).
        /// </summary>
        [JsonProperty("consolidation_level", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceConsolidationLevel? ConsolidationLevel { get; set; }

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
        /// 'proforma' value is deprecated in favor of proforma_adhoc and proforma_automatic
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProformaInvoiceRole? Role { get; set; }

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
        public List<Models.InvoiceCustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets PublicUrl.
        /// </summary>
        [JsonProperty("public_url")]
        public string PublicUrl
        {
            get
            {
                return this.publicUrl;
            }

            set
            {
                this.shouldSerialize["public_url"] = true;
                this.publicUrl = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProformaInvoice : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCustomerId()
        {
            this.shouldSerialize["customer_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSubscriptionId()
        {
            this.shouldSerialize["subscription_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNumber()
        {
            this.shouldSerialize["number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSequenceNumber()
        {
            this.shouldSerialize["sequence_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPublicUrl()
        {
            this.shouldSerialize["public_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerId()
        {
            return this.shouldSerialize["customer_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionId()
        {
            return this.shouldSerialize["subscription_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNumber()
        {
            return this.shouldSerialize["number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSequenceNumber()
        {
            return this.shouldSerialize["sequence_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePublicUrl()
        {
            return this.shouldSerialize["public_url"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProformaInvoice other &&
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
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.DeliveryDate == null && other.DeliveryDate == null ||
                 this.DeliveryDate?.Equals(other.DeliveryDate) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.CollectionMethod == null && other.CollectionMethod == null ||
                 this.CollectionMethod?.Equals(other.CollectionMethod) == true) &&
                (this.PaymentInstructions == null && other.PaymentInstructions == null ||
                 this.PaymentInstructions?.Equals(other.PaymentInstructions) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.ConsolidationLevel == null && other.ConsolidationLevel == null ||
                 this.ConsolidationLevel?.Equals(other.ConsolidationLevel) == true) &&
                (this.ProductName == null && other.ProductName == null ||
                 this.ProductName?.Equals(other.ProductName) == true) &&
                (this.ProductFamilyName == null && other.ProductFamilyName == null ||
                 this.ProductFamilyName?.Equals(other.ProductFamilyName) == true) &&
                (this.Role == null && other.Role == null ||
                 this.Role?.Equals(other.Role) == true) &&
                (this.Seller == null && other.Seller == null ||
                 this.Seller?.Equals(other.Seller) == true) &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.BillingAddress == null && other.BillingAddress == null ||
                 this.BillingAddress?.Equals(other.BillingAddress) == true) &&
                (this.ShippingAddress == null && other.ShippingAddress == null ||
                 this.ShippingAddress?.Equals(other.ShippingAddress) == true) &&
                (this.SubtotalAmount == null && other.SubtotalAmount == null ||
                 this.SubtotalAmount?.Equals(other.SubtotalAmount) == true) &&
                (this.DiscountAmount == null && other.DiscountAmount == null ||
                 this.DiscountAmount?.Equals(other.DiscountAmount) == true) &&
                (this.TaxAmount == null && other.TaxAmount == null ||
                 this.TaxAmount?.Equals(other.TaxAmount) == true) &&
                (this.TotalAmount == null && other.TotalAmount == null ||
                 this.TotalAmount?.Equals(other.TotalAmount) == true) &&
                (this.CreditAmount == null && other.CreditAmount == null ||
                 this.CreditAmount?.Equals(other.CreditAmount) == true) &&
                (this.PaidAmount == null && other.PaidAmount == null ||
                 this.PaidAmount?.Equals(other.PaidAmount) == true) &&
                (this.RefundAmount == null && other.RefundAmount == null ||
                 this.RefundAmount?.Equals(other.RefundAmount) == true) &&
                (this.DueAmount == null && other.DueAmount == null ||
                 this.DueAmount?.Equals(other.DueAmount) == true) &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                (this.Discounts == null && other.Discounts == null ||
                 this.Discounts?.Equals(other.Discounts) == true) &&
                (this.Taxes == null && other.Taxes == null ||
                 this.Taxes?.Equals(other.Taxes) == true) &&
                (this.Credits == null && other.Credits == null ||
                 this.Credits?.Equals(other.Credits) == true) &&
                (this.Payments == null && other.Payments == null ||
                 this.Payments?.Equals(other.Payments) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.PublicUrl == null && other.PublicUrl == null ||
                 this.PublicUrl?.Equals(other.PublicUrl) == true) &&
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
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"DeliveryDate = {(this.DeliveryDate == null ? "null" : this.DeliveryDate.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"CollectionMethod = {(this.CollectionMethod == null ? "null" : this.CollectionMethod.ToString())}");
            toStringOutput.Add($"PaymentInstructions = {this.PaymentInstructions ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"ConsolidationLevel = {(this.ConsolidationLevel == null ? "null" : this.ConsolidationLevel.ToString())}");
            toStringOutput.Add($"ProductName = {this.ProductName ?? "null"}");
            toStringOutput.Add($"ProductFamilyName = {this.ProductFamilyName ?? "null"}");
            toStringOutput.Add($"Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"Seller = {(this.Seller == null ? "null" : this.Seller.ToString())}");
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"SubtotalAmount = {this.SubtotalAmount ?? "null"}");
            toStringOutput.Add($"DiscountAmount = {this.DiscountAmount ?? "null"}");
            toStringOutput.Add($"TaxAmount = {this.TaxAmount ?? "null"}");
            toStringOutput.Add($"TotalAmount = {this.TotalAmount ?? "null"}");
            toStringOutput.Add($"CreditAmount = {this.CreditAmount ?? "null"}");
            toStringOutput.Add($"PaidAmount = {this.PaidAmount ?? "null"}");
            toStringOutput.Add($"RefundAmount = {this.RefundAmount ?? "null"}");
            toStringOutput.Add($"DueAmount = {this.DueAmount ?? "null"}");
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"Discounts = {(this.Discounts == null ? "null" : $"[{string.Join(", ", this.Discounts)} ]")}");
            toStringOutput.Add($"Taxes = {(this.Taxes == null ? "null" : $"[{string.Join(", ", this.Taxes)} ]")}");
            toStringOutput.Add($"Credits = {(this.Credits == null ? "null" : $"[{string.Join(", ", this.Credits)} ]")}");
            toStringOutput.Add($"Payments = {(this.Payments == null ? "null" : $"[{string.Join(", ", this.Payments)} ]")}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"PublicUrl = {this.PublicUrl ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}