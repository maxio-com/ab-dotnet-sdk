// <copyright file="SubscriptionGroupSignupFailureData.cs" company="APIMatic">
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
    /// SubscriptionGroupSignupFailureData.
    /// </summary>
    public class SubscriptionGroupSignupFailureData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupFailureData"/> class.
        /// </summary>
        public SubscriptionGroupSignupFailureData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupFailureData"/> class.
        /// </summary>
        /// <param name="payerId">payer_id.</param>
        /// <param name="payerReference">payer_reference.</param>
        /// <param name="paymentProfileId">payment_profile_id.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        /// <param name="payerAttributes">payer_attributes.</param>
        /// <param name="creditCardAttributes">credit_card_attributes.</param>
        /// <param name="bankAccountAttributes">bank_account_attributes.</param>
        /// <param name="subscriptions">subscriptions.</param>
        public SubscriptionGroupSignupFailureData(
            int? payerId = null,
            string payerReference = null,
            int? paymentProfileId = null,
            string paymentCollectionMethod = null,
            Models.PayerAttributes payerAttributes = null,
            Models.SubscriptionGroupCreditCard creditCardAttributes = null,
            Models.SubscriptionGroupBankAccount bankAccountAttributes = null,
            List<Models.SubscriptionGroupSignupItem> subscriptions = null)
        {
            this.PayerId = payerId;
            this.PayerReference = payerReference;
            this.PaymentProfileId = paymentProfileId;
            this.PaymentCollectionMethod = paymentCollectionMethod;
            this.PayerAttributes = payerAttributes;
            this.CreditCardAttributes = creditCardAttributes;
            this.BankAccountAttributes = bankAccountAttributes;
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// Gets or sets PayerId.
        /// </summary>
        [JsonProperty("payer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Gets or sets PayerReference.
        /// </summary>
        [JsonProperty("payer_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerReference { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileId.
        /// </summary>
        [JsonProperty("payment_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentProfileId { get; set; }

        /// <summary>
        /// Gets or sets PaymentCollectionMethod.
        /// </summary>
        [JsonProperty("payment_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentCollectionMethod { get; set; }

        /// <summary>
        /// Gets or sets PayerAttributes.
        /// </summary>
        [JsonProperty("payer_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayerAttributes PayerAttributes { get; set; }

        /// <summary>
        /// Gets or sets CreditCardAttributes.
        /// </summary>
        [JsonProperty("credit_card_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionGroupCreditCard CreditCardAttributes { get; set; }

        /// <summary>
        /// Gets or sets BankAccountAttributes.
        /// </summary>
        [JsonProperty("bank_account_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionGroupBankAccount BankAccountAttributes { get; set; }

        /// <summary>
        /// Gets or sets Subscriptions.
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionGroupSignupItem> Subscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSignupFailureData : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSignupFailureData other &&                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerReference == null && other.PayerReference == null) || (this.PayerReference?.Equals(other.PayerReference) == true)) &&
                ((this.PaymentProfileId == null && other.PaymentProfileId == null) || (this.PaymentProfileId?.Equals(other.PaymentProfileId) == true)) &&
                ((this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null) || (this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true)) &&
                ((this.PayerAttributes == null && other.PayerAttributes == null) || (this.PayerAttributes?.Equals(other.PayerAttributes) == true)) &&
                ((this.CreditCardAttributes == null && other.CreditCardAttributes == null) || (this.CreditCardAttributes?.Equals(other.CreditCardAttributes) == true)) &&
                ((this.BankAccountAttributes == null && other.BankAccountAttributes == null) || (this.BankAccountAttributes?.Equals(other.BankAccountAttributes) == true)) &&
                ((this.Subscriptions == null && other.Subscriptions == null) || (this.Subscriptions?.Equals(other.Subscriptions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerReference = {(this.PayerReference == null ? "null" : this.PayerReference)}");
            toStringOutput.Add($"this.PaymentProfileId = {(this.PaymentProfileId == null ? "null" : this.PaymentProfileId.ToString())}");
            toStringOutput.Add($"this.PaymentCollectionMethod = {(this.PaymentCollectionMethod == null ? "null" : this.PaymentCollectionMethod)}");
            toStringOutput.Add($"this.PayerAttributes = {(this.PayerAttributes == null ? "null" : this.PayerAttributes.ToString())}");
            toStringOutput.Add($"this.CreditCardAttributes = {(this.CreditCardAttributes == null ? "null" : this.CreditCardAttributes.ToString())}");
            toStringOutput.Add($"this.BankAccountAttributes = {(this.BankAccountAttributes == null ? "null" : this.BankAccountAttributes.ToString())}");
            toStringOutput.Add($"this.Subscriptions = {(this.Subscriptions == null ? "null" : $"[{string.Join(", ", this.Subscriptions)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}