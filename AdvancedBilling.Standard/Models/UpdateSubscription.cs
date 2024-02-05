// <copyright file="UpdateSubscription.cs" company="APIMatic">
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
    /// UpdateSubscription.
    /// </summary>
    public class UpdateSubscription
    {
        private bool? dunningCommunicationDelayEnabled;
        private string dunningCommunicationDelayTimeZone;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "dunning_communication_delay_enabled", false },
            { "dunning_communication_delay_time_zone", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscription"/> class.
        /// </summary>
        public UpdateSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscription"/> class.
        /// </summary>
        /// <param name="creditCardAttributes">credit_card_attributes.</param>
        /// <param name="productHandle">product_handle.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productChangeDelayed">product_change_delayed.</param>
        /// <param name="nextProductId">next_product_id.</param>
        /// <param name="nextProductPricePointId">next_product_price_point_id.</param>
        /// <param name="snapDay">snap_day.</param>
        /// <param name="nextBillingAt">next_billing_at.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        /// <param name="receivesInvoiceEmails">receives_invoice_emails.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="storedCredentialTransactionId">stored_credential_transaction_id.</param>
        /// <param name="reference">reference.</param>
        /// <param name="customPrice">custom_price.</param>
        /// <param name="components">components.</param>
        /// <param name="dunningCommunicationDelayEnabled">dunning_communication_delay_enabled.</param>
        /// <param name="dunningCommunicationDelayTimeZone">dunning_communication_delay_time_zone.</param>
        public UpdateSubscription(
            Models.CreditCardAttributes creditCardAttributes = null,
            string productHandle = null,
            int? productId = null,
            bool? productChangeDelayed = null,
            string nextProductId = null,
            string nextProductPricePointId = null,
            UpdateSubscriptionSnapDay snapDay = null,
            string nextBillingAt = null,
            string paymentCollectionMethod = null,
            bool? receivesInvoiceEmails = null,
            UpdateSubscriptionNetTerms netTerms = null,
            int? storedCredentialTransactionId = null,
            string reference = null,
            Models.SubscriptionCustomPrice customPrice = null,
            List<Models.UpdateSubscriptionComponent> components = null,
            bool? dunningCommunicationDelayEnabled = null,
            string dunningCommunicationDelayTimeZone = null)
        {
            this.CreditCardAttributes = creditCardAttributes;
            this.ProductHandle = productHandle;
            this.ProductId = productId;
            this.ProductChangeDelayed = productChangeDelayed;
            this.NextProductId = nextProductId;
            this.NextProductPricePointId = nextProductPricePointId;
            this.SnapDay = snapDay;
            this.NextBillingAt = nextBillingAt;
            this.PaymentCollectionMethod = paymentCollectionMethod;
            this.ReceivesInvoiceEmails = receivesInvoiceEmails;
            this.NetTerms = netTerms;
            this.StoredCredentialTransactionId = storedCredentialTransactionId;
            this.Reference = reference;
            this.CustomPrice = customPrice;
            this.Components = components;
            if (dunningCommunicationDelayEnabled != null)
            {
                this.DunningCommunicationDelayEnabled = dunningCommunicationDelayEnabled;
            }

            if (dunningCommunicationDelayTimeZone != null)
            {
                this.DunningCommunicationDelayTimeZone = dunningCommunicationDelayTimeZone;
            }

        }

        /// <summary>
        /// Gets or sets CreditCardAttributes.
        /// </summary>
        [JsonProperty("credit_card_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditCardAttributes CreditCardAttributes { get; set; }

        /// <summary>
        /// Set to the handle of a different product to change the subscription's product
        /// </summary>
        [JsonProperty("product_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductHandle { get; set; }

        /// <summary>
        /// Set to the id of a different product to change the subscription's product
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets ProductChangeDelayed.
        /// </summary>
        [JsonProperty("product_change_delayed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProductChangeDelayed { get; set; }

        /// <summary>
        /// Set to an empty string to cancel a delayed product change.
        /// </summary>
        [JsonProperty("next_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NextProductId { get; set; }

        /// <summary>
        /// Gets or sets NextProductPricePointId.
        /// </summary>
        [JsonProperty("next_product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NextProductPricePointId { get; set; }

        /// <summary>
        /// Use for subscriptions with product eligible for calendar billing only. Value can be 1-28 or 'end'.
        /// </summary>
        [JsonProperty("snap_day", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSubscriptionSnapDay SnapDay { get; set; }

        /// <summary>
        /// Gets or sets NextBillingAt.
        /// </summary>
        [JsonProperty("next_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public string NextBillingAt { get; set; }

        /// <summary>
        /// Gets or sets PaymentCollectionMethod.
        /// </summary>
        [JsonProperty("payment_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentCollectionMethod { get; set; }

        /// <summary>
        /// Gets or sets ReceivesInvoiceEmails.
        /// </summary>
        [JsonProperty("receives_invoice_emails", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReceivesInvoiceEmails { get; set; }

        /// <summary>
        /// Gets or sets NetTerms.
        /// </summary>
        [JsonProperty("net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateSubscriptionNetTerms NetTerms { get; set; }

        /// <summary>
        /// Gets or sets StoredCredentialTransactionId.
        /// </summary>
        [JsonProperty("stored_credential_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StoredCredentialTransactionId { get; set; }

        /// <summary>
        /// Gets or sets Reference.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// (Optional) Used in place of `product_price_point_id` to define a custom price point unique to the subscription
        /// </summary>
        [JsonProperty("custom_price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionCustomPrice CustomPrice { get; set; }

        /// <summary>
        /// (Optional) An array of component ids and custom prices to be added to the subscription.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateSubscriptionComponent> Components { get; set; }

        /// <summary>
        /// Enable Communication Delay feature, making sure no communication (email or SMS) is sent to the Customer between 9PM and 8AM in time zone set by the `dunning_communication_delay_time_zone` attribute.
        /// </summary>
        [JsonProperty("dunning_communication_delay_enabled")]
        public bool? DunningCommunicationDelayEnabled
        {
            get
            {
                return this.dunningCommunicationDelayEnabled;
            }

            set
            {
                this.shouldSerialize["dunning_communication_delay_enabled"] = true;
                this.dunningCommunicationDelayEnabled = value;
            }
        }

        /// <summary>
        /// Time zone for the Dunning Communication Delay feature.
        /// </summary>
        [JsonProperty("dunning_communication_delay_time_zone")]
        public string DunningCommunicationDelayTimeZone
        {
            get
            {
                return this.dunningCommunicationDelayTimeZone;
            }

            set
            {
                this.shouldSerialize["dunning_communication_delay_time_zone"] = true;
                this.dunningCommunicationDelayTimeZone = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDunningCommunicationDelayEnabled()
        {
            this.shouldSerialize["dunning_communication_delay_enabled"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDunningCommunicationDelayTimeZone()
        {
            this.shouldSerialize["dunning_communication_delay_time_zone"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDunningCommunicationDelayEnabled()
        {
            return this.shouldSerialize["dunning_communication_delay_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDunningCommunicationDelayTimeZone()
        {
            return this.shouldSerialize["dunning_communication_delay_time_zone"];
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
            return obj is UpdateSubscription other &&                ((this.CreditCardAttributes == null && other.CreditCardAttributes == null) || (this.CreditCardAttributes?.Equals(other.CreditCardAttributes) == true)) &&
                ((this.ProductHandle == null && other.ProductHandle == null) || (this.ProductHandle?.Equals(other.ProductHandle) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductChangeDelayed == null && other.ProductChangeDelayed == null) || (this.ProductChangeDelayed?.Equals(other.ProductChangeDelayed) == true)) &&
                ((this.NextProductId == null && other.NextProductId == null) || (this.NextProductId?.Equals(other.NextProductId) == true)) &&
                ((this.NextProductPricePointId == null && other.NextProductPricePointId == null) || (this.NextProductPricePointId?.Equals(other.NextProductPricePointId) == true)) &&
                ((this.SnapDay == null && other.SnapDay == null) || (this.SnapDay?.Equals(other.SnapDay) == true)) &&
                ((this.NextBillingAt == null && other.NextBillingAt == null) || (this.NextBillingAt?.Equals(other.NextBillingAt) == true)) &&
                ((this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null) || (this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true)) &&
                ((this.ReceivesInvoiceEmails == null && other.ReceivesInvoiceEmails == null) || (this.ReceivesInvoiceEmails?.Equals(other.ReceivesInvoiceEmails) == true)) &&
                ((this.NetTerms == null && other.NetTerms == null) || (this.NetTerms?.Equals(other.NetTerms) == true)) &&
                ((this.StoredCredentialTransactionId == null && other.StoredCredentialTransactionId == null) || (this.StoredCredentialTransactionId?.Equals(other.StoredCredentialTransactionId) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.CustomPrice == null && other.CustomPrice == null) || (this.CustomPrice?.Equals(other.CustomPrice) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.DunningCommunicationDelayEnabled == null && other.DunningCommunicationDelayEnabled == null) || (this.DunningCommunicationDelayEnabled?.Equals(other.DunningCommunicationDelayEnabled) == true)) &&
                ((this.DunningCommunicationDelayTimeZone == null && other.DunningCommunicationDelayTimeZone == null) || (this.DunningCommunicationDelayTimeZone?.Equals(other.DunningCommunicationDelayTimeZone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreditCardAttributes = {(this.CreditCardAttributes == null ? "null" : this.CreditCardAttributes.ToString())}");
            toStringOutput.Add($"this.ProductHandle = {(this.ProductHandle == null ? "null" : this.ProductHandle)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductChangeDelayed = {(this.ProductChangeDelayed == null ? "null" : this.ProductChangeDelayed.ToString())}");
            toStringOutput.Add($"this.NextProductId = {(this.NextProductId == null ? "null" : this.NextProductId)}");
            toStringOutput.Add($"this.NextProductPricePointId = {(this.NextProductPricePointId == null ? "null" : this.NextProductPricePointId)}");
            toStringOutput.Add($"SnapDay = {(this.SnapDay == null ? "null" : this.SnapDay.ToString())}");
            toStringOutput.Add($"this.NextBillingAt = {(this.NextBillingAt == null ? "null" : this.NextBillingAt)}");
            toStringOutput.Add($"this.PaymentCollectionMethod = {(this.PaymentCollectionMethod == null ? "null" : this.PaymentCollectionMethod)}");
            toStringOutput.Add($"this.ReceivesInvoiceEmails = {(this.ReceivesInvoiceEmails == null ? "null" : this.ReceivesInvoiceEmails.ToString())}");
            toStringOutput.Add($"NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"this.StoredCredentialTransactionId = {(this.StoredCredentialTransactionId == null ? "null" : this.StoredCredentialTransactionId.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : $"[{string.Join(", ", this.Components)} ]")}");
            toStringOutput.Add($"this.DunningCommunicationDelayEnabled = {(this.DunningCommunicationDelayEnabled == null ? "null" : this.DunningCommunicationDelayEnabled.ToString())}");
            toStringOutput.Add($"this.DunningCommunicationDelayTimeZone = {(this.DunningCommunicationDelayTimeZone == null ? "null" : this.DunningCommunicationDelayTimeZone)}");
        }
    }
}