// <copyright file="UpdateSubscription.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// UpdateSubscription.
    /// </summary>
    public class UpdateSubscription : BaseModel
    {
        private string dunningCommunicationDelayTimeZone;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
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
        /// <param name="initialBillingAt">initial_billing_at.</param>
        /// <param name="deferSignup">defer_signup.</param>
        /// <param name="nextBillingAt">next_billing_at.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        /// <param name="receivesInvoiceEmails">receives_invoice_emails.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="storedCredentialTransactionId">stored_credential_transaction_id.</param>
        /// <param name="reference">reference.</param>
        /// <param name="customPrice">custom_price.</param>
        /// <param name="components">components.</param>
        /// <param name="dunningCommunicationDelayEnabled">dunning_communication_delay_enabled.</param>
        /// <param name="dunningCommunicationDelayTimeZone">dunning_communication_delay_time_zone.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="productPricePointHandle">product_price_point_handle.</param>
        public UpdateSubscription(
            Models.CreditCardAttributes creditCardAttributes = null,
            string productHandle = null,
            int? productId = null,
            bool? productChangeDelayed = null,
            string nextProductId = null,
            string nextProductPricePointId = null,
            UpdateSubscriptionSnapDay snapDay = null,
            DateTimeOffset? initialBillingAt = null,
            bool? deferSignup = false,
            DateTimeOffset? nextBillingAt = null,
            DateTimeOffset? expiresAt = null,
            string paymentCollectionMethod = null,
            bool? receivesInvoiceEmails = null,
            UpdateSubscriptionNetTerms netTerms = null,
            int? storedCredentialTransactionId = null,
            string reference = null,
            Models.SubscriptionCustomPrice customPrice = null,
            List<Models.UpdateSubscriptionComponent> components = null,
            bool? dunningCommunicationDelayEnabled = null,
            string dunningCommunicationDelayTimeZone = null,
            int? productPricePointId = null,
            string productPricePointHandle = null)
        {
            this.CreditCardAttributes = creditCardAttributes;
            this.ProductHandle = productHandle;
            this.ProductId = productId;
            this.ProductChangeDelayed = productChangeDelayed;
            this.NextProductId = nextProductId;
            this.NextProductPricePointId = nextProductPricePointId;
            this.SnapDay = snapDay;
            this.InitialBillingAt = initialBillingAt;
            this.DeferSignup = deferSignup;
            this.NextBillingAt = nextBillingAt;
            this.ExpiresAt = expiresAt;
            this.PaymentCollectionMethod = paymentCollectionMethod;
            this.ReceivesInvoiceEmails = receivesInvoiceEmails;
            this.NetTerms = netTerms;
            this.StoredCredentialTransactionId = storedCredentialTransactionId;
            this.Reference = reference;
            this.CustomPrice = customPrice;
            this.Components = components;
            this.DunningCommunicationDelayEnabled = dunningCommunicationDelayEnabled;

            if (dunningCommunicationDelayTimeZone != null)
            {
                this.DunningCommunicationDelayTimeZone = dunningCommunicationDelayTimeZone;
            }
            this.ProductPricePointId = productPricePointId;
            this.ProductPricePointHandle = productPricePointHandle;
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
        /// (Optional) Set this attribute to a future date/time to update a subscription in the Awaiting Signup Date state, to Awaiting Signup. In the Awaiting Signup state, a subscription behaves like any other. It can be canceled, allocated to, or have its billing date changed. etc. When the `initial_billing_at` date hits, the subscription will transition to the expected state. If the product has a trial, the subscription will enter a trial, otherwise it will go active. Setup fees will be respected either before or after the trial, as configured on the price point. If the payment is due at the initial_billing_at and it fails the subscription will be immediately canceled. You can omit the initial_billing_at date to activate the subscription immediately. See the [subscription import](https://maxio.zendesk.com/hc/en-us/articles/24251489107213-Advanced-Billing-Subscription-Imports#date-format) documentation for more information about Date/Time formats.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("initial_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InitialBillingAt { get; set; }

        /// <summary>
        /// (Optional) Set this attribute to true to move the subscription from Awaiting Signup, to Awaiting Signup Date. Use this when you want to update a subscription that has an unknown initial billing date. When the first billing date is known, update a subscription to set the `initial_billing_at` date. The subscription moves to the awaiting signup with a scheduled initial billing date. You can omit the initial_billing_at date to activate the subscription immediately. See [Subscription States](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404222005773-Subscription-States) for more information.
        /// </summary>
        [JsonProperty("defer_signup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeferSignup { get; set; }

        /// <summary>
        /// Gets or sets NextBillingAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextBillingAt { get; set; }

        /// <summary>
        /// Timestamp giving the expiration date of this subscription (if any). You may manually change the expiration date at any point during a subscription period.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresAt { get; set; }

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
        [JsonProperty("dunning_communication_delay_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DunningCommunicationDelayEnabled { get; set; }

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

        /// <summary>
        /// Set to change the current product's price point.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// Set to change the current product's price point.
        /// </summary>
        [JsonProperty("product_price_point_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointHandle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDunningCommunicationDelayTimeZone()
        {
            this.shouldSerialize["dunning_communication_delay_time_zone"] = false;
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscription other &&
                (this.CreditCardAttributes == null && other.CreditCardAttributes == null ||
                 this.CreditCardAttributes?.Equals(other.CreditCardAttributes) == true) &&
                (this.ProductHandle == null && other.ProductHandle == null ||
                 this.ProductHandle?.Equals(other.ProductHandle) == true) &&
                (this.ProductId == null && other.ProductId == null ||
                 this.ProductId?.Equals(other.ProductId) == true) &&
                (this.ProductChangeDelayed == null && other.ProductChangeDelayed == null ||
                 this.ProductChangeDelayed?.Equals(other.ProductChangeDelayed) == true) &&
                (this.NextProductId == null && other.NextProductId == null ||
                 this.NextProductId?.Equals(other.NextProductId) == true) &&
                (this.NextProductPricePointId == null && other.NextProductPricePointId == null ||
                 this.NextProductPricePointId?.Equals(other.NextProductPricePointId) == true) &&
                (this.SnapDay == null && other.SnapDay == null ||
                 this.SnapDay?.Equals(other.SnapDay) == true) &&
                (this.InitialBillingAt == null && other.InitialBillingAt == null ||
                 this.InitialBillingAt?.Equals(other.InitialBillingAt) == true) &&
                (this.DeferSignup == null && other.DeferSignup == null ||
                 this.DeferSignup?.Equals(other.DeferSignup) == true) &&
                (this.NextBillingAt == null && other.NextBillingAt == null ||
                 this.NextBillingAt?.Equals(other.NextBillingAt) == true) &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                (this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null ||
                 this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true) &&
                (this.ReceivesInvoiceEmails == null && other.ReceivesInvoiceEmails == null ||
                 this.ReceivesInvoiceEmails?.Equals(other.ReceivesInvoiceEmails) == true) &&
                (this.NetTerms == null && other.NetTerms == null ||
                 this.NetTerms?.Equals(other.NetTerms) == true) &&
                (this.StoredCredentialTransactionId == null && other.StoredCredentialTransactionId == null ||
                 this.StoredCredentialTransactionId?.Equals(other.StoredCredentialTransactionId) == true) &&
                (this.Reference == null && other.Reference == null ||
                 this.Reference?.Equals(other.Reference) == true) &&
                (this.CustomPrice == null && other.CustomPrice == null ||
                 this.CustomPrice?.Equals(other.CustomPrice) == true) &&
                (this.Components == null && other.Components == null ||
                 this.Components?.Equals(other.Components) == true) &&
                (this.DunningCommunicationDelayEnabled == null && other.DunningCommunicationDelayEnabled == null ||
                 this.DunningCommunicationDelayEnabled?.Equals(other.DunningCommunicationDelayEnabled) == true) &&
                (this.DunningCommunicationDelayTimeZone == null && other.DunningCommunicationDelayTimeZone == null ||
                 this.DunningCommunicationDelayTimeZone?.Equals(other.DunningCommunicationDelayTimeZone) == true) &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                (this.ProductPricePointHandle == null && other.ProductPricePointHandle == null ||
                 this.ProductPricePointHandle?.Equals(other.ProductPricePointHandle) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreditCardAttributes = {(this.CreditCardAttributes == null ? "null" : this.CreditCardAttributes.ToString())}");
            toStringOutput.Add($"ProductHandle = {this.ProductHandle ?? "null"}");
            toStringOutput.Add($"ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"ProductChangeDelayed = {(this.ProductChangeDelayed == null ? "null" : this.ProductChangeDelayed.ToString())}");
            toStringOutput.Add($"NextProductId = {this.NextProductId ?? "null"}");
            toStringOutput.Add($"NextProductPricePointId = {this.NextProductPricePointId ?? "null"}");
            toStringOutput.Add($"SnapDay = {(this.SnapDay == null ? "null" : this.SnapDay.ToString())}");
            toStringOutput.Add($"InitialBillingAt = {(this.InitialBillingAt == null ? "null" : this.InitialBillingAt.ToString())}");
            toStringOutput.Add($"DeferSignup = {(this.DeferSignup == null ? "null" : this.DeferSignup.ToString())}");
            toStringOutput.Add($"NextBillingAt = {(this.NextBillingAt == null ? "null" : this.NextBillingAt.ToString())}");
            toStringOutput.Add($"ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"PaymentCollectionMethod = {this.PaymentCollectionMethod ?? "null"}");
            toStringOutput.Add($"ReceivesInvoiceEmails = {(this.ReceivesInvoiceEmails == null ? "null" : this.ReceivesInvoiceEmails.ToString())}");
            toStringOutput.Add($"NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"StoredCredentialTransactionId = {(this.StoredCredentialTransactionId == null ? "null" : this.StoredCredentialTransactionId.ToString())}");
            toStringOutput.Add($"Reference = {this.Reference ?? "null"}");
            toStringOutput.Add($"CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");
            toStringOutput.Add($"Components = {(this.Components == null ? "null" : $"[{string.Join(", ", this.Components)} ]")}");
            toStringOutput.Add($"DunningCommunicationDelayEnabled = {(this.DunningCommunicationDelayEnabled == null ? "null" : this.DunningCommunicationDelayEnabled.ToString())}");
            toStringOutput.Add($"DunningCommunicationDelayTimeZone = {this.DunningCommunicationDelayTimeZone ?? "null"}");
            toStringOutput.Add($"ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"ProductPricePointHandle = {this.ProductPricePointHandle ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}